using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TestDB
{
    /// <summary>
    /// Klasse om de TypeMachine objecten op te halen uit de database
    /// </summary>
    /// <author>Wim Baens</author>
    public class TypeMachineDB
    {
        /// <summary> 
        /// haalt alle Types uit de database en geeft ze als Type objecten terug
        /// </summary>
        /// <param name="machines">lijst gevuld met Machine objecten</param> 
        /// <returns>lijst met Type objecten</returns> 
        /// <author>Wim Baens</author>  
        public static List<TypeMachine> getTypes()
        {
            List<TypeMachine> types = new List<TypeMachine>();

            SqlConnection conn = ConnectionDB.getConnection();
            string selectStatement;
            SqlCommand selectCommand;

            selectStatement = "SELECT TypeNaam,TypeID " +
                            "FROM Types " +
                            "ORDER BY TypeID";
            selectCommand = new SqlCommand(selectStatement, conn);


            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    types.Add(new TypeMachine(reader["TypeNaam"].ToString(), Convert.ToInt32(reader["TypeID"])));
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return types;
        }
    }
}
