using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dovetail.DatabaseAPI
{
    public static class UserAccountHandler
    {
        private static SqlConnection GetDovetailDbConnection()
        {
            // SQL Server database connection information
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dovetail2018.database.windows.net";
            builder.UserID = "admin0"; 
            builder.Password = "bronco!devs098";
            builder.InitialCatalog = "dovetail-db";

            return new SqlConnection(builder.ConnectionString);
        }

        public static bool UserSignIn(string username, string password)
        {
            // Prepare connection to the database
            SqlConnection connection = GetDovetailDbConnection();
            bool canSignIn = false;

            // Attempt to connect to database and verify user credentials
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Prepare sign-in query
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(1) ");
                sb.Append("FROM Users ");
                sb.Append("WHERE Username = @Username AND Password = @Password AND Access = 1;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                // Execute query; only one valid user should be found/returned
                int queryResult = Convert.ToInt32(command.ExecuteScalar());
                if (queryResult != 1)
                {
                    connection.Close();
                    return false;
                }

                // Sign-in is successful
                canSignIn = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return canSignIn;
        }

        public static bool UserSignOut(string username)
        {
            return false;
        }
        
        public static bool RegisterNewUser(string username, string password, string firstName, string lastName, string email, string userType, int hasAccess)
        {
            return false;
        }

        public static void RevokeAccessForUser(string username)
        {

        }

        public static void AllowAccessForUser(string username)
        {

        }

        public static void UserUpdatePassword(string oldPass, string newPass)
        {

        }

        public static void UserUpdateWage(double newWage)
        {

        }

        public static void UserUpdateEmail(string newEmail)
        {

        }
    }
}
