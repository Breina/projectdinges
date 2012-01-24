using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Research.DynamicDataDisplay.DataSources.MultiDimensional;
using Microsoft.Research.DynamicDataDisplay.Common.Auxiliary;
using Microsoft.Research.DynamicDataDisplay.Charts;

namespace TestProject
{
    public partial class HoofdScherm : Form
    {
        public HoofdScherm()
        {
            InitializeComponent();
        }

        private void knopImporteren_Click(object sender, EventArgs e)
        {
            ExcelToSqlForm form = new ExcelToSqlForm();
            form.Show();
        }

        private void knopVisualizeren_Click(object sender, EventArgs e)
        {
            IntensityChart.Window1 g = new IntensityChart.Window1();
            g.Show();
        }

        private void knopExporteren_Click(object sender, EventArgs e)
        {
            SqlToExcelForm form = new SqlToExcelForm();
            form.Show();
        }
    }
}
