using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestDB;

namespace TestProject
{
    public partial class Inloggen : Form
    {

        public Inloggen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDB.inloggen(loginTextBox.Text, passwordTextBox.Text);
                HoofdScherm form = new HoofdScherm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
