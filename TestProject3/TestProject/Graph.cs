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

namespace Motorozoid
{

    public partial class Graph : Form
    {
        private ElementHost ctrlHost;
        private Grafiek wpfAddressCtrl;
        
        public Graph(string pad, int machine)
        {
            InitializeComponent();
            wpfAddressCtrl = new Grafiek(pad, machine);
            ctrlHost = new ElementHost();
            elementHost1.Size = new System.Drawing.Size(400,300);

            elementHost1.Child = wpfAddressCtrl;
            this.Controls.Add(elementHost1);
        }
      
            
    }
}
