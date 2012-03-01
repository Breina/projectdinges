using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MotoroziodDB;
using System.IO;

namespace Motorozoid
{
    /// <summary> 
    /// Klasse om een bestand uit de database te kiezen dat wordt weggeschreven in een excelbestand
    /// </summary>
    /// <author>Wim Baens</author>
    public partial class SqlToExcelForm : Form
    {
        private HoofdSchermForm hoofdscherm;

        /// <summary> 
        /// Constructor van de klasse SqlToExcelForm
        /// </summary>
        /// <param name="hoofdscherm">object van het type HoofdSchermForm</param>          
        /// <author>Wim Baens</author> 
        public SqlToExcelForm(HoofdSchermForm hoofdscherm)
        {
            InitializeComponent();
            this.hoofdscherm = hoofdscherm;
            hoofdscherm.Enabled = false;
            bestandenListBox.DataSource = BestandDB.getBestandNamen();
            controleerListBox();
        }

        private void naarExcelButton_Click(object sender, EventArgs e)
        {
            string bestandsNaam = bestandsNaamTextBox.Text;
            try
            {

                if (bestandsNaam.Equals("") || bestandsNaam.Contains('.') || bestandsNaam.Contains('/') || bestandsNaam.Contains('\\'))
                {
                    MessageBox.Show(this, "Vul een correcte bestandsnaam in!", "Foute bestandsnaam", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    if (excelFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string opslaanPad = excelFolderBrowserDialog.SelectedPath;
                        FileInfo file = new FileInfo(opslaanPad + "\\"+bestandsNaam + ".xlsx");
                        if (file.Exists)
                        {
                            MessageBox.Show(this, "Bestand bestaat al in de gekozen map, verander de bestandsnaam of map!", "Bestand Bestaat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ExcelDB.sqlToExcel(bestandenListBox.SelectedValue.ToString(),file);
                            this.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void anulleerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary> 
        /// Controleert of er objecten in de bestandenListBox zitten
        /// </summary>   
        /// <author>Wim Baens</author> 
        private void controleerListBox()
        {
            int aantal = bestandenListBox.Items.Count;
            if (aantal < 1)
            {
                naarExcelButton.Enabled = false;
                leegLabel.Text = "Geen bestanden in de database!";
            }
            else
            {
                bestandsNaamTextBox.Text = getBestandsNaam();
            }
        }

        private void SqlToExcelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoofdscherm.Enabled = true;
        }

        /// <summary> 
        /// Haalt de bestandsnaam uit het object van type FileInfo
        /// </summary> 
        /// <returns>een string</returns>
        /// <author>Wim Baens</author> 
        private string getBestandsNaam()
        {
            string bestandsNaam = bestandenListBox.SelectedValue.ToString();
            FileInfo file = new FileInfo(bestandsNaam);
            int index = file.Name.IndexOf('.');
            bestandsNaam = file.Name.Remove(index);

            return bestandsNaam;
        }

        private void bestandenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controleerListBox();
        }
    }
}
