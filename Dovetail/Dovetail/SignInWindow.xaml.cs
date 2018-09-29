using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Dovetail.DatabaseAPI;

namespace Dovetail
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// Implementation of Task #60
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            DovetailMainForm mainForm = new DovetailMainForm();
            WindowInteropHelper wih = new WindowInteropHelper(new Window());
            wih.Owner = mainForm.Handle;
            //mainForm.Show();


            InitializeComponent();
        }

        /// <summary>
        /// Interaction logic for Sign In button
        /// </summary>
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            Sign_In();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Sign_In();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register();
        }

        private void Register()
        {
            RegisterForm rf = new RegisterForm();
            this.Hide();
            rf.ShowDialog();
            this.Show();
        }

        private void Sign_In()
        {
            bool signInSuccess = UserAccountHandler.UserSignIn(txtUsername.Text, txtPassword.Password);

            if (!signInSuccess)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                SignInAlertMsgLabel.Content = "Username or password is incorrect!";
                return;
            }

            // Show main dashboard window
            DovetailMainForm dashboard = new DovetailMainForm();
            dashboard.Show();
            Close();    // close sign in window
        }
    }
}
