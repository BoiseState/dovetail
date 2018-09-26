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
                MessageBox.Show("fuck ya, we're connected. dick to pussy");
                this.Close();
                // Check username/password/access query
                //StringBuilder sb = new StringBuilder();
                //sb.Append("INSERT COUNT(1) ");
                //sb.Append("FROM Users ");
                //sb.Append("WHERE Username = @Username AND Password = @Password AND Access = 1;");
                //String sql = sb.ToString();

                //SqlCommand command = new SqlCommand(sql, connection);
                //command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("@Username", txtUsername.Text);
                //command.Parameters.AddWithValue("@Password", txtPassword.Password);

                //int count = Convert.ToInt32(command.ExecuteScalar());
                //if (count == 1)
                //{
                //   // Show main dashboard window (TODO: show userType-specific window)
                //    DovetailMainForm dashboard = new DovetailMainForm();
                //    dashboard.Show();
                //    Close();    // close sign in window
                //}
                //else
                //{
                //    txtUsername.Clear();
                //    txtPassword.Clear();
                //   MessageBox.Show("Username or password is incorrect!");  // may want to show error message text in-window, not popup
                //}
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
