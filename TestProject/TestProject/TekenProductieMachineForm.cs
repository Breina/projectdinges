using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MotorozoidDB;
using IntensityChart;

namespace Motorozoid
{
    public partial class TekenProductieMachineForm : Form
    {
        private Grafiek grafiek;
        List<Machine> motors;
        List<Machine> overbrengingen;
        List<Machine> belastingen;
        private double besteRendament;
        private Points besteNominaleWaarden;
        private int selectedProductieMachine;
        HoofdSchermForm hoofdscherm;
        bool motorGetekend = false;
        bool overbrengingGetekend = false;
        bool belastingGetekend= false;

        public TekenProductieMachineForm(HoofdSchermForm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
            hoofdscherm.Enabled = false;
         
            productieMachineComboBox.DataSource = ProductieMachineDB.getProductieMachines();
            laadGegevens();
        }

        private void tekenGrafiek()
        {
            tekenMotor();
            tekenBelasting();
            tekenOverbrenging();    
        }
       
        private void tekenOverbrenging()
        {
            if (overbrengingListBox.SelectedIndex != -1)
            {
                Machine machine = overbrengingen[overbrengingListBox.SelectedIndex];
                grafiek = new Grafiek(machine);
                overbrengingHost.Child = grafiek;
                this.Controls.Add(overbrengingHost);
                overbrengingGetekend = true;

            }
            else
            {
                overbrengingGetekend = false;
            }
        }

        private void tekenBelasting()
        {
            if (belastingListBox.SelectedIndex != -1)
            {
                Machine machine = belastingen[belastingListBox.SelectedIndex];
                grafiek = new Grafiek(machine);
                belastingHost.Child = grafiek;
                this.Controls.Add(belastingHost);
                besteRendament = TekenDB.geefBesteRendament(machine);
                besteNominaleWaarden = TekenDB.geefBesteNominaleWaarden(machine.BesteNominaalID);
                belastingGetekend = true;
            }
            else
            {
                belastingGetekend = false;
            }
        }

        private void tekenMotor()
        {
            if (motorListBox.SelectedIndex != -1)
            {
                Machine machine = motors[motorListBox.SelectedIndex];
                grafiek = new Grafiek(machine);
                motorHost.Child = grafiek;
                this.Controls.Add(motorHost);
                besteRendament = TekenDB.geefBesteRendament(machine);
                besteNominaleWaarden = TekenDB.geefBesteNominaleWaarden(machine.BesteNominaalID);
                motorGetekend = true;
            }
            else
            {
                motorGetekend = false;
            }
        }

        private void motorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            tekenMotor();
        }


        private void overbrengingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
  
            tekenOverbrenging();
        }

        private void belastingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            tekenBelasting();
        }

        private void productieMachineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Remove(motorHost);
            this.Controls.Remove(belastingHost);
            this.Controls.Remove(overbrengingHost);
            laadGegevens();
        }

        public void laadGegevens(){
             this.selectedProductieMachine = productieMachineComboBox.SelectedIndex + 1;
            motors = MachineDB.getMachinesPerType(0, selectedProductieMachine);
            overbrengingen = MachineDB.getMachinesPerType(1, selectedProductieMachine);
            belastingen = MachineDB.getMachinesPerType(2, selectedProductieMachine);
            motorListBox.DataSource = motors;
            overbrengingListBox.DataSource = overbrengingen;
            belastingListBox.DataSource = belastingen;
            tekenGrafiek();
            controleerGetekend();
           
        }

        private void AnnuleerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TekenProductieMachineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoofdscherm.Enabled = true;
        }

        private void tekenTotaalButton_Click(object sender, EventArgs e)
        {
            GrafiekForm form = new GrafiekForm(motors[motorListBox.SelectedIndex],overbrengingen[overbrengingListBox.SelectedIndex],belastingen[belastingListBox.SelectedIndex]);
            form.Show();
        }

        private void controleerGetekend()
        {
            if (motorGetekend && overbrengingGetekend && belastingGetekend)
            {
                tekenTotaalButton.Enabled = true;
            }
            else
            {
                tekenTotaalButton.Enabled = false;
            }
        }
       
    }
}
