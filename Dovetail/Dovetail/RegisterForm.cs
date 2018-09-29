using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dovetail.DatabaseAPI;

namespace Dovetail
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool registerSuccess = UserAccountHandler.RegisterNewUser(new DovetailUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, "employee", true));

            if (!registerSuccess)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Registration Failed. Pick another User/Pass");  // may want to show error message text in-window, not popup
                return;
            }

            Close();    // close sign in window
        }
    }
}
