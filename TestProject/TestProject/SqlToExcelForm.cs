using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class SqlToExcelForm : Form
    {

        private string map;
        public SqlToExcelForm()
        {
            InitializeComponent();
            sqlToExcelButton.Enabled = false;
        }


        private void sqlToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                TestDB.TestDB1 test = new TestDB.TestDB1();

                listBox1.DataSource = test.sqlToExcel(textBox1.Text, map);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void saveMap_Click(object sender, EventArgs e)
        {


            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sqlToExcelButton.Enabled = true;
                map = folderBrowserDialog1.SelectedPath;
                mapTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
