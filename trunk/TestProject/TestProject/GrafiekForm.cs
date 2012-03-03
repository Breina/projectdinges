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
using MotorozoidDB;

namespace Motorozoid
{

    public partial class GrafiekForm : Form
    {      
        private Grafiek grafiek;
        private Machine machine;    
       
        
        public GrafiekForm(string pad, Machine machine)
        {
            InitializeComponent();
            
            this.machine = machine;
            this.Text = machine.MachineNaam;
            grafiek = new Grafiek(pad, machine);
        
            grafiekHost.Size = new System.Drawing.Size(400,300);

            grafiekHost.Child = grafiek;
            this.Controls.Add(grafiekHost);       
          
        }

        public GrafiekForm(Machine motor, Machine overbrenging, Machine belasting)
        {
            InitializeComponent();

           
            this.Text = "Totale Isorendamentscurve";
            grafiek = new Grafiek(motor, overbrenging,belasting);

            grafiekHost.Size = new System.Drawing.Size(400, 300);

            grafiekHost.Child = grafiek;
            this.Controls.Add(grafiekHost);   
        }
            
    }
}
