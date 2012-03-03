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
    public partial class EditProductieMachineForm : Form
    {

        private HoofdSchermForm hoofdscherm;
        List<ProductieMachine> productieMachines;
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
