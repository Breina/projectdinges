using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TestDB
{
    /// <summary> 
    /// Klasse om connectie te maken met de database
    /// </summary>
    /// <author>Wim Baens</author>
    public class ConnectionDB
    {
        /// <summary> 
        /// Haalt de connectiestring op
        /// </summary>       
        /// <returns>de connectiestring</returns>
        /// <author>Wim Baens</author>  
        public static SqlConnection getConnection()
        {
            string connectionString =
                "Data Source=.\\SqlExpress;AttachDbFilename=|DataDirectory|\\DataTest.mdf;Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
