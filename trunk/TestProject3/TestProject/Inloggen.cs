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

        private TestDB1 test = new TestDB1();
        public Inloggen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                test.inloggen(loginTextBox.Text, passwordTextBox.Text);
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
