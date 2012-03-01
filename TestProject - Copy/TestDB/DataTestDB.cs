using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TestDB
{
    public class DataTestDB
    {
        public static SqlConnection getConnection()
        {
            string connectionString =
                "Data Source=.\\SqlExpress;AttachDbFilename=|DataDirectory|\\DataTest.mdf;Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
