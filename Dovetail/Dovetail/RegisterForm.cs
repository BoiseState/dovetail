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
                // Check username/password/access query
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Users ");
                sb.Append("VALUES (@Username, @Password, @FirstName, @LastName, @Email, 'Employee', 1);");
                String sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Username", textBox1.Text);
                command.Parameters.AddWithValue("@Password", textBox2.Text);
                command.Parameters.AddWithValue("@FirstName", textBox3.Text);
                command.Parameters.AddWithValue("@LastName", textBox4.Text);
                command.Parameters.AddWithValue("@Email", textBox5.Text);

                int result = command.ExecuteNonQuery();
                if (result == 1)
                {
                   Close();    // close sign in window
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                   MessageBox.Show("Registration Failed. Pick another User/Pass");  // may want to show error message text in-window, not popup
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
