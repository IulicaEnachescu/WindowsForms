using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public sealed class ConnectionManager
    {
        private static SqlConnection connection = null;
        private ConnectionManager()
        { }
        public static SqlConnection GetConnection()

        {
            if (connection == null)
            {
                
                string connectionString = "Data Source=.; Initial Catalog=FormsProject; Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }

            return connection;
        }
        public static SqlConnection OpenConnection(SqlConnection connection)
        {
            if (connection == null) return null;
            else
            {
                connection.Open();
                return connection;
            }

        }
    }
}
