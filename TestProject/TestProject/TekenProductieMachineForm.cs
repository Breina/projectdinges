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
    /// <summary> 
    /// Klasse om grafieken weer te geven per productiemachine
    /// </summary>
    /// <author>Wim Baens</author>
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

        /// <summary> 
        /// Constructor van de klasse TekenProductieMachineForm
        /// </summary>
        /// <param name="hoofdscherm">object van het type HoofdSchermForm</param>          
        /// <author>Wim Baens</author> 
        public TekenProductieMachineForm(HoofdSchermForm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
            hoofdscherm.Enabled = false;
         
            productieMachineComboBox.DataSource = ProductieMachineDB.getProductieMachines();
            laadGegevens();
        }

        /// <summary> 
        /// Geeft al de grafieken weer
        /// </summary>               
        /// <author>Wim Baens</author> 
        private void tekenGrafiek()
        {
            tekenMotor();
            tekenBelasting();
            tekenOverbrenging();    
        }

        /// <summary> 
        /// Geeft de overbrenginggrafiek weer als er een overbrenging is geselecteerd in de lijst
        /// </summary>               
        /// <author>Wim Baens</author> 
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

        /// <summary> 
        /// Geeft de belastinggrafiek weer als er een belasting is geselecteerd in de lijst
        /// </summary>               
        /// <author>Wim Baens</author> 
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

        /// <summary> 
        /// Geeft de motorgrafiek weer als er een motor is geselecteerd in de lijst
        /// </summary>               
        /// <author>Wim Baens</author> 
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
        /// <summary> 
        ///Laadt al de gegevens in voor de lijsten te vullen en grafieken weer te geven
        /// </summary>               
        /// <author>Wim Baens</author> 
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

        /// <summary> 
        /// Controleert of alle grafieken getekend zijn
        /// </summary>               
        /// <author>Wim Baens</author> 
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
