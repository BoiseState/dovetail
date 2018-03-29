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
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dovetail2018.database.windows.net";
            builder.UserID = "admin0";
            builder.Password = "bronco!devs098";
            builder.InitialCatalog = "dovetail-db";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
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
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
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
