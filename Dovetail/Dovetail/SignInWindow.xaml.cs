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
            // SQL Server database connection information
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dovetail2018.database.windows.net";
            builder.UserID = "admin0";
            builder.Password = "bronco!devs098";
            builder.InitialCatalog = "dovetail-db";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            // Attempt to connect to database and verify user credentials
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                // Check username/password/access query
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(1) ");
                sb.Append("FROM Users ");
                sb.Append("WHERE Username = @Username AND Password = @Password AND Access = 1;");
                String sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = CommandType.Text;
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Password))
                {
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Password);
                }
                else
                {
                    // Username and/or password were not present. Simply bail out and alert the user.
                    txtUsername.Clear();
                    txtPassword.Clear();
                    SignInAlertMsgLabel.Content = "Incomplete sign-in credentials!";
                    return;
                }

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    // Show main dashboard window (TODO: show userType-specific window)
                    DovetailMainForm dashboard = new DovetailMainForm();
                    dashboard.Show();
                    Close();    // close sign in window
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    SignInAlertMsgLabel.Content = "Username or password is incorrect!";
                }
            }
            catch (SqlException sqle)
            {
                txtPassword.Clear();
                MessageBox.Show(sqle.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
