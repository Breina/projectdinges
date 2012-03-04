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
    /// <summary>
    /// Gui klasse om een grafiek weer te geven
    /// </summary>
    /// <author>Kenny Vaneetvelde</author>
    public partial class GrafiekForm : Form
    {      
        private Grafiek grafiek;
        private Machine machine;

        /// <summary> 
        /// Constructor van de klasse GrafiekForm
        /// </summary>
        /// <param name="pad">een tekst</param> 
        /// <param name="machine">een object van het type Machine</param>
        /// <author>Kenny Vaneetvelde</author>
        /// <author>Wim Baens: code aangepast om het te laten werken</author> 
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

        /// <summary> 
        /// Constructor van de klasse GrafiekForm
        /// </summary>
        /// <param name="motor">een object van het type Machine</param> 
        /// <param name="overbrenging">een object van het type Machine</param>
        /// <param name="belasting">een object van het type Machine</param>
        /// <author>Wim Baens</author> 
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
