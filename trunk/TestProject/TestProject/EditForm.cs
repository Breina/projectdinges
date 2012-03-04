using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MotorozoidDB;
using System.Data.SqlClient;

namespace Motorozoid
{
    /// <summary>
    /// GUI Klasse om een machine aan te kunnen passen of een bestand te verwijderen
    /// </summary>
    /// <author>Wim Baens</author>
    public partial class EditForm : Form
    {
        private List<Bestand> bestanden;
        private List<Machine> machines;
        private HoofdSchermForm hoofdscherm;

        /// <summary> 
        /// Constructor van de klasse EditForm
        /// </summary>
        /// <param name="hoofdscherm">object van het type HoofdSchermForm</param>          
        /// <author>Wim Baens</author> 
        public EditForm(HoofdSchermForm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
            hoofdscherm.Enabled = false;
            bestanden = BestandDB.getBestandNamen();
            bestandPadComboBox.DataSource = bestanden;
            vulComboBoxEnGrid();

        }

        /// <summary> 
        /// Vult de gridview
        /// </summary> 
        /// <param name="m">een lijst van Machine Objecten</param>          
        /// <author>Wim Baens</author> 
        private void fillGridView(List<Machine> m)
        {
            string naam;
            List<TypeMachine> types = TypeMachineDB.getTypes();
            List<ProductieMachine> prodMach = ProductieMachineDB.getProductieMachines();
            Type.DataSource = types;
            Type.DisplayMember = "TypeNaam";
            Type.ValueMember = "TypeId";
            ProductieMachine.DataSource = prodMach;
            ProductieMachine.DisplayMember = "ProductieMachineNaam";
            ProductieMachine.ValueMember = "ProductieMachineID";
            foreach (Machine mach in m)
            {
                naam = mach.MachineNaam;
                mach.NominaalToerental = 1500;
                naam.Replace('-', ' ');

                try
                {
                    string[] s = naam.Split(' ');
                    mach.Label = s[1];
                    string vermogenString = s[0].Trim(new char[] { 'k', 'W', 'K', 'w' });
                    mach.Vermogen = Convert.ToDouble(vermogenString);
                    mach.NominaalKoppel = Math.Round(Convert.ToDouble(mach.Vermogen * 1000 / (2 * Math.PI * 25)), 2);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Geen bruikbare data in de machinenaam. Vul alles zelf in!", "Format fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                machinesDataGridView.Rows.Add(naam, mach.TypeId, mach.Label, mach.Vermogen, mach.NominaalToerental, mach.NominaalKoppel, mach.ProductieMachineID - 1);
            }
        }

        private void bestandPadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vulComboBoxEnGrid();
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateMachine();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("U heeft niet alles ingevuld. Vul alles correct in!", "Input fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul alles correct in!", "Input fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary> 
        /// Vult een lijst met Machine objecten en geeft deze mee aan een update method
        /// </summary>                
        /// <author>Wim Baens</author>
        private void updateMachine()
        {
            int l = machinesDataGridView.RowCount;

            for (int i = 0; i < l; i++)
            {
                machines[i].MachineNaam = machinesDataGridView["Naam", i].Value.ToString();
                machines[i].TypeId = Convert.ToInt32(machinesDataGridView["Type", i].Value);
                machines[i].Vermogen = Convert.ToDouble(machinesDataGridView["Vermogen", i].Value);
                machines[i].NominaalToerental = Convert.ToDouble(machinesDataGridView["NominaalToerental", i].Value);
                machines[i].NominaalKoppel = Convert.ToInt32(machinesDataGridView["NominaalKoppel", i].Value);
                machines[i].Label = machinesDataGridView["Label", i].Value.ToString();
                machines[i].ProductieMachineID = Convert.ToInt32(machinesDataGridView["ProductieMachine", i].Value) + 1;
            }

            MachineDB.updateMachineData(machines, bestandPadComboBox.SelectedValue.ToString());


            this.Close();
        }

        private void annuleerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBestand_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoofdscherm.refresh();
            hoofdscherm.Enabled = true;
        }

       
        private void verwijderButton_Click(object sender, EventArgs e)
        {
            if (bestandPadComboBox.Items.Count > 0)
            {
                if (MessageBox.Show(this, "Bent u zeker dat het bestand mag verwijderd worden?", "Verwijderen bestand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string pad = bestandPadComboBox.SelectedValue.ToString();
                    try
                    {
                        BestandDB.verwijderBestand(pad);
                        bestanden = BestandDB.getBestandNamen();
                        bestandPadComboBox.DataSource = bestanden;
                        vulComboBoxEnGrid();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        /// <summary> 
        /// Vult de gridview
        /// </summary>                
        /// <author>Wim Baens</author>
        private void vulComboBoxEnGrid()
        {
            machinesDataGridView.Rows.Clear();
            int selectedIndex = bestandPadComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                opslaanButton.Enabled = true;
                verwijderButton.Enabled = true;
                try
                {
                    machines = MachineDB.getMachines(bestandPadComboBox.SelectedValue.ToString());
                    fillGridView(machines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                verwijderButton.Enabled = false;
                opslaanButton.Enabled = false;
                bestandPadComboBox.DataSource = null;
                leegLabel.Text = "Geen bestanden in de database!";
            }
        }

    }
}
