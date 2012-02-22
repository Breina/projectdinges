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
using System.Data.SqlClient;

namespace TestProject
{
    /// <summary>
    /// Klasse van het hoofdscherm
    /// </summary>
    /// <author>Brecht Derwael</author>
    public partial class HoofdSchermForm : Form
    {
        private List<Bestand> bestanden;
        private List<Machine> machines;
        private InlogForm inlogForm;

        /// <summary> 
        /// Constructor van de klasse HoofdSchermForm
        /// </summary>
        /// <param name="inlogForm">object van het type InlogForm</param>         
        /// <author>Wim Baens en Brecht Derwael</author> 
        public HoofdSchermForm(InlogForm inlogForm)
        {
            InitializeComponent();
            this.inlogForm = inlogForm;
            inlogForm.Visible = false;
            refreshLists();
        }
        
        private void knopImporteren_Click(object sender, EventArgs e)
        {
            ExcelToSqlForm form = new ExcelToSqlForm(this);
            form.Show();
        }

        private void knopVisualizeren_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(getGeselecteerdPad(), getGeselecteerdeMachine());
            Window1 g = new IntensityChart.Window1(getGeselecteerdPad(), getGeselecteerdeMachine());
            graph.Show();
        }

        private void knopExporteren_Click(object sender, EventArgs e)
        {
            SqlToExcelForm form = new SqlToExcelForm();
            form.Show();
        }

        /// <summary> 
        /// roept de methods op die de listboxen refreshen
        /// </summary>            
        /// <author>Brecht Derwael</author> 
        private void refreshLists()
        {
            refreshBestanden();
            refreshMachines();
        }

        /// <summary> 
        /// refreshed de machineListBox
        /// </summary>        
        /// <author>Brecht Derwael</author> 
        /// <author>Wim Baens: mag niet uitgevoerd worden als pad is null</author>
        private void refreshMachines()
        {
            machinesListBox.DataSource = null;
            string pad = getGeselecteerdPad();
            if (pad != null)
            {
                machines = MachineDB.getMachinesNaam(pad);
                machinesListBox.DataSource = machines;
            }
        }

        /// <summary> 
        /// refreshed de bestandenListBox
        /// </summary>        
        /// <author>Brecht Derwael</author>         
        private void refreshBestanden()
        {
            bestandenListBox.DataSource = null;
            bestanden = BestandDB.getBestandNamen();
            bestandenListBox.DataSource = bestanden;
        }

        /// <summary> 
        /// geeft het geselecteerde pad van het bestand terug
        /// </summary>        
        /// <returns>tekst of waarde null</returns>
        /// <author>Brecht Derwael</author> 
        /// <author>Wim Baens: geeft null terug als er niks geselecteerd is</author>
        private string getGeselecteerdPad()
        {
            string pad = null;
            if (bestandenListBox.SelectedIndex != -1)
            {
                pad = bestanden[bestandenListBox.SelectedIndex].Pad;
            }

            return pad;
        }

        /// <summary> 
        /// geeft de machineId terug van de geselecteerde machine
        /// </summary>        
        /// <returns>positief geheel getal</returns>
        /// <author>Brecht Derwael</author>        
        private int getGeselecteerdeMachine()
        {

            return machines[machinesListBox.SelectedIndex].MachineId;
        }

        public void refresh()
        {
            refreshLists();
        }

        private void bestandenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshMachines();
        }      

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inlogForm.Close();
        }

        private void importerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelToSqlForm form = new ExcelToSqlForm(this);
            form.Show();
        }

        private void visualizerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window1 g = new IntensityChart.Window1(getGeselecteerdPad(), getGeselecteerdeMachine());
            g.Show();
        }

        private void exporterenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlToExcelForm form = new SqlToExcelForm();
            form.Show();
        }

        private void bestandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(this);
            form.Show();
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoofdSchermForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inlogForm.Visible = true;
        }

    }
}
