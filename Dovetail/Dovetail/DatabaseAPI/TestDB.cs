using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dovetail.DatabaseAPI
{
    /// <summary>
    /// SQL Server connection to the Dovetail server/database (hosted on Microsoft Azure).
    /// </summary>
    public static class TestDB
    {
        /// <summary>
        /// Establishes a database connection to the Dovetail server.
        /// Developer is responsible to close the connection before function exit.
        /// </summary>
        /// <returns>SqlConnection to 'dovetail-db'</returns>
        public static Boolean TestConnection()
        {
            try
            {
                SqlConnection connection = DovetailDbConnection.GetConnection();
                return true;
            } catch
            {
                return false;
            }
        }
        public static Boolean RegisterSignInRemove()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 10.0, true);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.UserSignIn(test);
            if (result)
            {
                result = UserAccountHandler.RemoveUser(test);
            }
            return result;
        }
        public static Boolean RevokeAccess()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 10.0, true);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.RevokeAccessForUser("test");
            if (result)
            {
                result = UserAccountHandler.RemoveUser(test);
            }
            return result;
        }
        public static Boolean AllowAccess()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 10.0, false);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.AllowAccessForUser("test");
            if (result)
            {
                result = UserAccountHandler.RemoveUser(test);
            }
            return result;
        }
        public static Boolean UsernameUpdate()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 10.0, false);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.UserUpdateUsername("test", "test1");
            if (result)
            {
                if(test.Username != "test1")
                {
                    result = false;

                }
            }
            bool remove = UserAccountHandler.RemoveUser(test);
            return result;
        }
        public static Boolean PasswordUpdate()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 10.0, false);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.UserUpdatePassword("test", "test1");
            if(result)
            {
                if(test.Password != "test1")
                {
                    result = false;
                }
            }
            bool remove = UserAccountHandler.RemoveUser(test);
            return result;
        }
        public static Boolean WageUpdate()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 9.0, false);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.UserUpdateWage("test", 10.0);
            if (result)
            {
                if (test.Wage != 10.0)
                {
                    result = false;
                }
            }
            bool remove = UserAccountHandler.RemoveUser(test);
            return result;
        }
        public static Boolean EmailUpdate()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 9.0, false);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.UserUpdateEmail("test", "test1");
            if (result)
            {
                if (test.Email != "test1")
                {
                    result = false;
                }
            }
            bool remove = UserAccountHandler.RemoveUser(test);
            return result;
        }
        public static Boolean UserTypeUpdate()
        {
            DovetailUser test = new DovetailUser("test", "test", "test", "test", "test", "test", 10.0, false);
            bool result = UserAccountHandler.RegisterNewUser(test);
            result = UserAccountHandler.UserUpdateUserType("test", "test1");
            if (result)
            {
                if (test.UserType != "test1")
                {
                    result = false;
                }
            }
            bool remove = UserAccountHandler.RemoveUser(test);
            return result;
        }

    }
}
