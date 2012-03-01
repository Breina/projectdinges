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
            int width = 50;
            int height = 50;

            double[,] data = new double[width, height];

            // Hier moet ik de dingskes van de database krijge

            Point[,] gridData = new Point[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    gridData[y, x] = new Point(y, x);   // Kan zijn da ge de x en y moet spiegele hier, ge ziet maar
                }
            }

            // As ik dit hier in ne .xaml krijg denk ik da het wel gaat werke
            WarpedDataSource2D<double> dataSource = new WarpedDataSource2D<double>(data, gridData);

            isolineGraph.DataSource = dataSource;
            trackingGraph.DataSource = dataSource;

            Rect visible = dataSource.GetGridBounds();
            plotter.Viewport.Visible = visible;
        }
    }
}
