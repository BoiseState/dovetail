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
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    // Show main dashboard window (TODO: show userType-specific window)
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    Close();    // close sign in window
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("Username or password is incorrect!");  // may want to show error message text in-window, not popup
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
