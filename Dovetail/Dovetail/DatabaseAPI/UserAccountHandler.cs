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
        /// <summary>
        /// API procedure for signing the specified user into the Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True, if success; false otherwise</returns>
        public static bool UserSignIn(DovetailUser user)
        {
            // Prepare connection to the database
            SqlConnection connection = DovetailDbConnection.GetConnection();
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

                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);

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

        /// <summary>
        /// API procedure for signing the specified user out of the Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True, if success; false otherwise</returns>
        public static bool UserSignOut(string username)
        {
            return false;
        }

        /// <summary>
        /// API procedure for creating/registering a new user for the Dovetail software.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>True, if success; false otherwise</returns>
        public static bool RegisterNewUser(DovetailUser user)
        {
            // Prepare connection to the database
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool canRegisterUser = false;

            // Attempt to connect to database and verify user credentials
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Users ");
                sb.Append("VALUES (@Username, @Password, @FirstName, @LastName, @Email, @UserType, @Access);");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.Email))
                {
                    connection.Close();
                    return false;
                }

                if (!IsValidEmail(user.Email))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@UserType", user.UserType);
                command.Parameters.AddWithValue("@Access", user.HasAccess);

                // Execute query; only one valid user should be created/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // New user successfully registered
                canRegisterUser = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return canRegisterUser;
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

        public static void UserUpdateUserType(string username, string newUserType)
        {

        }

        /// <summary>
        /// Validates specified email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
