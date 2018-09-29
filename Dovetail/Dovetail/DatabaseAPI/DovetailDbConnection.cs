using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dovetail.DatabaseAPI
{
    public static class DovetailDbConnection
    {
        /// <summary>
        /// GetConnection:
        /// Establishes a database connection to the Dovetail server.
        /// </summary>
        /// <returns>SqlConnection to dovetail-db</returns>
        public static SqlConnection GetConnection()
        {
            // SQL Server database connection information
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dovetail2018.database.windows.net";
            builder.UserID = "admin0";
            builder.Password = "bronco!devs098";
            builder.InitialCatalog = "dovetail-db";

            return new SqlConnection(builder.ConnectionString);
        }
    }
}
