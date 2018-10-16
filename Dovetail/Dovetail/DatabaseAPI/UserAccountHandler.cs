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
    /// <summary>
    /// A Dovetail database API specifically used for handling user account controls.
    /// </summary>
    public static class UserAccountHandler
    {
        #region User sign-in controls
        /// <summary>
        /// API procedure for signing the specified user into the Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True, if sign-in successful; false otherwise</returns>
        public static bool UserSignIn(DovetailUser user)
        {
            // Prepare connection to the database
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool canSignIn = false;
            
            //unhashing hashed password 
            string savedPasswordHash = user.Password;
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes,0,salt,0,16);
            var pbkdf2 = new Rfc2898DeriveBytes(user.Password,salt,10000);
            byte[] hash = pbkdft.GetBytes(20);
            bool same = true;
            for(int i = 0; i < 20; i++) {
                if(hashBytes[i+16]!=hash[i]) 
                    same = false;
             }                                       
            // Attempt to connect to database and verify user credentials
            try
            {
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
        /// API procedure for removing the specified user into the Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True, if remove successful; false otherwise</returns>
        public static bool RemoveUser(DovetailUser user)
        {
            // Prepare connection to the database
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool canRemove = false;

            // Attempt to connect to database and verify user credentials
            try
            {
                // Prepare sign-in query
                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE COUNT(1) ");
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
                canRemove = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return canRemove;
        }

        /// <summary>
        /// API procedure for signing the specified user out of the Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True, if success; false otherwise</returns>
        public static bool UserSignOut(string username)
        {
            throw new NotImplementedException("User sign-out is not yet implemented for DatabaseAPI!");
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
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(user.Password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt,0,hashBytes,0,16);
            Array.Copy(hash,0,hashBytes,16,20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            //todo store with savedPasswordHash, but everything is g2g

            // Attempt to connect to database and verify user credentials
            try
            {
                // Check if user already exists
                if (UserAlreadyExists(user.Username))
                {
                    connection.Close();
                    return false;
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

                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password) || 
                    string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || 
                    string.IsNullOrEmpty(user.Email))
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
        #endregion

        #region User profile update controls
        /// <summary>
        /// API procedure for revoking the specified user's access to Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True, if access revoked successfully; false otherwise</returns>
        public static bool RevokeAccessForUser(string username)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool revokeAccessSuccess = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET Access = 0 ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User access has been successfully revoked
                revokeAccessSuccess = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return revokeAccessSuccess;
        }

        /// <summary>
        /// API procedure for allowing access for the specified user's account in Dovetail software.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True, if access updated successfully; false otherwise</returns>
        public static bool AllowAccessForUser(string username)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool allowAccessSuccess = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET Access = 1 ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User's access has been successfully allowed
                allowAccessSuccess = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return allowAccessSuccess;
        }

        /// <summary>
        /// API procedure for updating the user's username to the new username.
        /// </summary>
        /// <param name="oldUsername"></param>
        /// <param name="newUsername"></param>
        /// <returns>True, if username change is successful; false otherwise</returns>
        public static bool UserUpdateUsername(string oldUsername, string newUsername)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool usernameUpdateSuccess = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET Username = @NewUsername ");
                sb.Append("WHERE Username = @OldUsername;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(oldUsername) || string.IsNullOrEmpty(newUsername))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@OldUsername", oldUsername);
                command.Parameters.AddWithValue("@NewUsername", newUsername);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User's username has been successfully updated
                usernameUpdateSuccess = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return usernameUpdateSuccess;
        }

        /// <summary>
        /// API procedure for updating the user's password to the new password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newPassword"></param>
        /// <returns>True, if username change is successful; false otherwise</returns>
        public static bool UserUpdatePassword(string username, string newPassword)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool passwordUpdatedSuccessfully = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET Password = @Password ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", newPassword);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User's password has been successfully updated
                passwordUpdatedSuccessfully = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return passwordUpdatedSuccessfully;
        }

        /// <summary>
        /// API procedure for updating the specified user's wage to the new wage.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newWage"></param>
        /// <returns>True, if user's wage updated successfully; false otherwise</returns>
        public static bool UserUpdateWage(string username, double newWage)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool wageUpdatedSuccessfully = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET Wage = @NewWage ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username) || newWage < 0)
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@NewWage", newWage);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User's wage has been successfully updated
                wageUpdatedSuccessfully = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return wageUpdatedSuccessfully;
        }

        /// <summary>
        /// API procedure for updating the specified user's email to the new email address.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newEmail"></param>
        /// <returns>True, if email updated successfully; false otherwise</returns>
        public static bool UserUpdateEmail(string username, string newEmail)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool emailUpdatedSuccessfully = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET Email = @NewEmail ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newEmail))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@NewEmail", newEmail);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User's email has been successfully updated
                emailUpdatedSuccessfully = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return emailUpdatedSuccessfully;
        }

        /// <summary>
        /// API procedure for updating the specified user's privileges to the new user type.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newUserType"></param>
        /// <returns>True, if user type updated successfully; false otherwise</returns>
        public static bool UserUpdateUserType(string username, string newUserType)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool UserTypeUpdatedSuccessfully = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users ");
                sb.Append("SET UserType = @NewUserType ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newUserType))
                {
                    connection.Close();
                    return false;
                }

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@NewUserType", newUserType);

                // Execute query; only one valid user should be updated/returned
                int result = command.ExecuteNonQuery();
                if (result != 1)
                {
                    connection.Close();
                    return false;
                }

                // User's email has been successfully updated
                UserTypeUpdatedSuccessfully = true;
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return UserTypeUpdatedSuccessfully;
        }
        #endregion

        #region API helpers
        /// <summary>
        /// Validates specified email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True, if email is valid; false otherwise</returns>
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

        /// <summary>
        /// Check if the specified user already exists in the database.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True, if user already exists; false otherwise</returns>
        private static bool UserAlreadyExists(string username)
        {
            SqlConnection connection = DovetailDbConnection.GetConnection();
            bool userAlreadyExists = false;

            try
            {
                // Prepare register new user query
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM Users ");
                sb.Append("WHERE Username = @Username;");
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection)
                {
                    CommandType = CommandType.Text
                };

                command.Parameters.AddWithValue("@Username", username);

                // Execute query; only one valid user should be found/returned
                int queryResult = Convert.ToInt32(command.ExecuteScalar());
                if (queryResult > 0)
                {
                    userAlreadyExists = true;
                }
            }
            catch (SqlException sqle)
            {
                connection.Close();
                MessageBox.Show(sqle.Message);
            }

            connection.Close();

            return userAlreadyExists;
        }
        #endregion
    }
}
