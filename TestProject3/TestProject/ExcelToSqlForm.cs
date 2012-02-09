﻿using System;
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

namespace TestProject
{
    public partial class ExcelToSqlForm : Form
    {
        private string fileName;
        public ExcelToSqlForm()
        {
            InitializeComponent();
            //zetOmButton.Enabled = false;
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
                fileTextBox.Text = openFileDialog1.FileName;
                
               
                TestDB1.excelToSql(openFileDialog1.FileName);

                btnOK.Enabled = true;
                btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

    }
}
