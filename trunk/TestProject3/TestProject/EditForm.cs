using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestDB;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class EditForm : Form
    {
        private List<Bestand> bestanden;
       private List<Machine> machines;
      private  HoofdSchermForm hoofdscherm;
        public EditForm(HoofdSchermForm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
            hoofdscherm.Enabled = false;
            bestanden = BestandDB.getBestandNamen();
            bestandPadComboBox.DataSource = bestanden;
            vulComboBoxEnGrid();
            
        }

        private void fillGridView(List<Machine> m)
        {            
                string naam;
                List<TypeMachine> types = TypeMachineDB.getTypes();
                Type.DataSource = types;
                Type.DisplayMember = "TypeNaam";
                Type.ValueMember = "TypeId";
                foreach (Machine machine in m)
                {
                    if (machine.Vermogen == 0 && machine.NominaalKoppel == 0 && machine.Label == "")
                    {
                        naam = machine.MachineNaam;
                        machine.NominaalToerental = 1500;
                        try
                        {
                            string[] s = naam.Split(' ');
                            machine.Label = s[1];
                            string vermogenString = s[0].Trim(new char[] { 'k', 'W', 'K', 'w' });
                            machine.Vermogen = Convert.ToDouble(vermogenString);
                            machine.NominaalKoppel = Math.Round(Convert.ToDouble(machine.Vermogen * 1000 / (2 * Math.PI * 25)), 2);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Geen bruikbare data in de machinenaam. Vul alles zelf in!", "Format fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    machinesDataGridView.Rows.Add(machine.MachineNaam, machine.TypeId, machine.Label, machine.Vermogen, machine.NominaalToerental, machine.NominaalKoppel);
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
                        // Add productiemachine
                    }
               
                MachineDB.updateMachineData(machines);
            
           
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
            if (bestandPadComboBox.SelectedIndex != -1)
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

        private void vulComboBoxEnGrid()
        {    
           
            machinesDataGridView.Rows.Clear();
            int selectedIndex = bestandPadComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                opslaanButton.Enabled = true;
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
                opslaanButton.Enabled = false;
                bestandLabel.Text = "Geen bestanden in de database, voeg eerst bestanden toe!";
            }
        }

    }
}
