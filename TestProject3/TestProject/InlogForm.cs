using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestDB;
using System.Data.SqlClient;

namespace TestProject
{
    /// <summary> 
    /// Klasse van het InlogForm 
    /// </summary>
    /// <author>Wim Baens</author>
    public partial class InlogForm : Form
    {

        public InlogForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDB.inloggen(loginTextBox.Text, passwordTextBox.Text);
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                HoofdSchermForm form = new HoofdSchermForm(this);
                form.Show();
            }
            catch (LoginException ex)
            {
                MessageBox.Show(this, ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
