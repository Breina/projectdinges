using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestDB;
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace TestProject
{
    public partial class ExcelToSqlForm : Form
    {
        private string fileName;
        private Machine[] machines;
        private HoofdScherm hoofdscherm;

        public ExcelToSqlForm(HoofdScherm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
        }

        private void kiesExcelButton_Click(object sender, EventArgs e)
        {
            loadExcel();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            loadExcel();
        }

        private void loadExcel()
        {
            openFileDialog1.Filter = "Excelbestanden(*.xlsx)|*.xlsx";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                fileTextBox.Text = fileName;
                if (BestandDB.controleerPad(fileName))
                {

                    machines = TestDB1.excelToSql(openFileDialog1.FileName);


                    fillGridView(machines);

                    btnOK.Enabled = true;
                    btnOK.Focus();
                }
                else
                {
                    MessageBox.Show("Excel bestand bestaat al. Lees een ander bestand in.");
                }
            }
        }





        private void fillGridView(Machine[] m)
        {
            //dataGridView.DataSource = machines;
            int l = machines.Length;
            String naam;

            for (int i = 0; i < l; i++)
            {
                naam = m[i].MachineNaam;

                String[] s = naam.Split(' ');
                String label = s[1];

                // TODO: Parse da fatsoenlek! -Brecht
                String vermogenString = s[0].Trim(new char[] { 'k', 'W' });
                s = null;

                double d = Convert.ToDouble(vermogenString);
                d *= 1000;
                int vermogen = Convert.ToInt32(d);
                int nomKoppel = (int)(vermogen / (2 * Math.PI * 25));

                dataGridView.Rows.Add(naam, "", label, vermogen, 1500, nomKoppel);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int l = dataGridView.RowCount;

            for (int i = 0; i < l; i++)
            {
                machines[i].TypeId = Convert.ToInt32(dataGridView["Type", i].Value);
                machines[i].Vermogen = Convert.ToInt32(dataGridView["Vermogen", i].Value);
                machines[i].NominaalToerental = Convert.ToDouble(dataGridView["NomToer", i].Value);
                machines[i].NominaalKoppel = Convert.ToInt32(dataGridView["NomKopp", i].Value);
                machines[i].Label = dataGridView["Label", i].Value.ToString();
                // Add productiemachine
            }

            MachineDB.writeMachineData(machines);
            hoofdscherm.refresh();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
