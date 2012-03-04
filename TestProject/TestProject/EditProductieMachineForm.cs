using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MotorozoidDB;

namespace Motorozoid
{
    /// <summary>
    /// GUI Klasse om een productiemachine toe te voegen of aan te passen
    /// </summary>
    /// <author>Wim Baens</author>
    public partial class EditProductieMachineForm : Form
    {

        private HoofdSchermForm hoofdscherm;
        List<ProductieMachine> productieMachines;

        /// <summary> 
        /// Constructor van de klasse EditProductieMachineForm
        /// </summary>
        /// <param name="hoofdscherm">object van het type HoofdSchermForm</param>          
        /// <author>Wim Baens</author> 
        public EditProductieMachineForm(HoofdSchermForm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
            hoofdscherm.Enabled = false;
            productieMachines = ProductieMachineDB.getProductieMachines();
            productieMachineComboBox.DataSource = productieMachines;
            naamTextBox.Text = productieMachineComboBox.SelectedItem.ToString();
            controleerComboBox();
            
        }

        private void productieMachineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controleerComboBox();
            naamTextBox.Text = productieMachineComboBox.SelectedItem.ToString();
        }

        private void annuleerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProductieMachineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoofdscherm.Enabled = true;
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            string naam = naamTextBox.Text;
            if (!naam.Equals(""))
            {
                try
                {
                    
                    ProductieMachine machine = productieMachines[productieMachineComboBox.SelectedIndex];
                    machine.ProductieMachineID++;
                    machine.ProductieMachineNaam = naam;
                    ProductieMachineDB.updateProductieMachine(machine);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Input fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Gelieve een naam in te vullen!", "Input fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary> 
        /// Controleert of 'Geen' is geselecteerd in de combobox
        /// </summary>              
        /// <author>Wim Baens</author> 
        private void controleerComboBox()
        {
            if (productieMachineComboBox.SelectedItem.ToString().Equals("Geen"))
            {
                naamTextBox.Enabled = false;
                opslaanButton.Enabled = false;
                toevoegenButton.Enabled = false;
            }
            else
            {
                naamTextBox.Enabled = true;
                opslaanButton.Enabled = true;
                toevoegenButton.Enabled = true;
            }
        }

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            string naam = naamTextBox.Text;
            if (!naam.Equals(""))
            {
                try
                {
                    ProductieMachineDB.addProductieMachine(naam);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Input fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Gelieve een naam in te vullen!", "Input fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
