using System;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IntensityChart;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using MotoroziodDB;

namespace Motorozoid
{

    public partial class GrafiekForm : Form
    {      
        private Grafiek wpfAddressCtrl;
        private Machine machine;
        private double besteRendament;
        private Points besteNominaleWaarden;
       
        
        public GrafiekForm(string pad, Machine machine)
        {
            InitializeComponent();
            
            this.machine = machine;
            this.Text = machine.MachineNaam;
            wpfAddressCtrl = new Grafiek(pad, machine.MachineId);
        
            grafiekHost.Size = new System.Drawing.Size(400,300);

            grafiekHost.Child = wpfAddressCtrl;
            this.Controls.Add(grafiekHost);
            besteRendament = TekenDB.geefBesteRendament(machine);
            besteNominaleWaarden = TekenDB.geefBesteNominaleWaarden(machine.BesteNominaalID);
            rendamentLabel.Text = "Beste rendament: " +Math.Round(besteRendament,4);
            toerentalLabel.Text = "Bij Toerental: " + machine.NominaalToerental*besteNominaleWaarden.getToerental();
            koppelLabel.Text = "En Koppel: " + machine.NominaalKoppel * besteNominaleWaarden.getKoppel() ;
        }            
            
    }
}
