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

namespace TestProject
{
    public partial class ExcelToSqlForm : Form
    {
        private string fileName;
        private TestDB1 test;
        public ExcelToSqlForm()
        {
            InitializeComponent();
        }

        private void kiesExcelButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excelbestanden(*.xlsx)|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                fileTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void zetOmButton_Click(object sender, EventArgs e)
        {
            test = new TestDB1();
           List<string> list =  test.excelToSql(openFileDialog1.FileName);
           listBox1.DataSource = list;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
