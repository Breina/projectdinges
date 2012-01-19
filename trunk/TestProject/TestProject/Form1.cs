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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excelToSqlButton_Click(object sender, EventArgs e)
        {
            ExcelToSqlForm form = new ExcelToSqlForm();
            form.Show();
        }

        private void sqlToExcelButton_Click(object sender, EventArgs e)
        {
            SqlToExcelForm form = new SqlToExcelForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntensityChart.Window1 g = new IntensityChart.Window1();
            g.Show();
        }
    }
}
