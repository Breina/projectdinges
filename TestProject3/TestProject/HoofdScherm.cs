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
using TestDB;
using IntensityChart;

namespace TestProject
{
    public partial class HoofdScherm : Form
    {
        private List<Bestand> bestanden;
        private List<Machine> machines;

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
            double[,] d = TestDB1.getData(getGeselecteerdPad(), getGeselecteerdeMachine());
            Window1 g = new IntensityChart.Window1(d);
            d = null;

            g.Show();
        }

        private void knopExporteren_Click(object sender, EventArgs e)
        {
            SqlToExcelForm form = new SqlToExcelForm();
            form.Show();
        }

        private void HoofdScherm_Load(object sender, EventArgs e)
        {
            refreshLists();
        }

        private void refreshLists()
        {
            refreshBestanden();
            refreshMachines();
        }

        private void refreshMachines()
        {   
            machines = TestDB1.getMachineNamen(getGeselecteerdPad());
            machinesListBox.DataSource = machines;
            machinesListBox.DisplayMember = "getNaam";
        }

        private void refreshBestanden()
        {
            bestanden = TestDB1.getBestandNamen();
            bestandenListBox.DataSource = bestanden;
            bestandenListBox.DisplayMember = "getNaam";
        }

        private String getGeselecteerdPad()
        {
            return bestanden[bestandenListBox.SelectedIndex].getPad();
        }

        private int getGeselecteerdeMachine()
        {
            return machines[machinesListBox.SelectedIndex].getId();
        }

        private void bestandenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshMachines();
        }
    }
}
