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
    public static class DovetailDbConnection
    {
        /// <summary>
        /// Establishes a database connection to the Dovetail server.
        /// Developer is responsible to close the connection before function exit.
        /// </summary>
        /// <returns>SqlConnection to 'dovetail-db'</returns>
        public static SqlConnection GetConnection()
        {
            // SQL Server database connection information
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "dovetail2018.database.windows.net",
                UserID = "admin0",
                Password = "bronco!devs098",
                InitialCatalog = "dovetail-db"
            };

            // Create the database connection instance
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            // Make sure the connection is open and ready for anyone to use out of the box
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }
    }
}
