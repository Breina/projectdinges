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
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace Motorozoid
{

    public partial class Graph : Form
    {
        private ElementHost ctrlHost;
        private IntensityChart.Window1 wpfAddressCtrl;
        
        public Graph(string pad, int machine)
        {
            InitializeComponent();
            wpfAddressCtrl = new IntensityChart.Window1(pad, machine);
        }

        private void Graph_Load(object sender, EventArgs e)
        {
             ctrlHost = new ElementHost();
            ctrlHost.Dock = DockStyle.Fill;
            panel1.Controls.Add(ctrlHost);           
            wpfAddressCtrl.InitializeComponent();
            ctrlHost.Child = wpfAddressCtrl;

        }
    }
}
