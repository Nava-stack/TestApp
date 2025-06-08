using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Helpers
{
    internal class Database
    {
        private static readonly string connectionString = @"Data Source=NAVA;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
