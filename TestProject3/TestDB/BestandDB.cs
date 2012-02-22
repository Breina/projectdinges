using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TestDB
{
    /// <summary> 
    /// Klasse voor controle en ophalen van bestanden uit de database
    /// </summary>
    /// <author>Wim Baens</author>
    public class BestandDB
    {
        /// <summary> 
        /// Haalt de namen van de bestanden op uit de database
        /// </summary>       
        /// <returns>lijst van Bestand objecten</returns>
        /// <author>Wim Baens</author>  
        public static List<Bestand> getBestandNamen()
        {
            List<Bestand> bestanden = new List<Bestand>();

            SqlConnection conn = ConnectionDB.getConnection();
            string selectStatement;
            SqlCommand selectCommand;

            selectStatement = "SELECT DISTINCT BestandPad " +
                            "FROM MachineBestand";
            selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    bestanden.Add(new Bestand(reader["BestandPad"].ToString()));
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return bestanden;
        }

        /// <summary> 
        /// Controleert of een padnaam al bestaat
        /// </summary>   
        /// <param name="pad">tekst</param>
        /// <returns>true als het pad niet bestaat, false als het pad bestaat</returns>
        /// <author>Wim Baens</author>  
        public static bool controleerPad(string pad)
        {
            bool bestaatNiet = true;

            SqlCommand selectCommand;
            string selectStatement;
            SqlConnection conn = ConnectionDB.getConnection();
            selectStatement = "SELECT BestandPad " +
               "FROM MachineBestand " +
               "WHERE BestandPad=@BestandPad";

            selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@BestandPad", pad);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    bestaatNiet = false;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return bestaatNiet;
        }

        /// <summary> 
        /// Verwijderd alles van een bestand
        /// </summary>   
        /// <param name="pad">tekst</param>      
        /// <author>Wim Baens</author>  
        public static void verwijderBestand(string pad)
        {
            List<int> machineId = new List<int>();
            List<int> MachineBestandId = new List<int>();

            SqlConnection conn = ConnectionDB.getConnection();
            string selectStatement;
            string deleteStatement;
            SqlCommand selectCommand;
            SqlCommand deleteCommand;           

            selectStatement = "SELECT  MachineID, MachineBestandID " +
                            "FROM MachineBestand "+
                             "WHERE BestandPad=@BestandPad";
            selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@BestandPad", pad);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    machineId.Add(Convert.ToInt32(reader["MachineID"]));
                    MachineBestandId.Add(Convert.ToInt32(reader["MachineBestandID"]));
                }
                reader.Close();
                foreach (int id in MachineBestandId)
                {
                    deleteStatement = "DELETE FROM Rendamenten " +
                                      "WHERE MachineBestandID = @MachineBestandID";
                    deleteCommand = new SqlCommand(deleteStatement, conn);
                    deleteCommand.Parameters.AddWithValue("@MachineBestandID", id);
                    deleteCommand.ExecuteNonQuery();
                    deleteStatement = "DELETE FROM MachineBestand " +
                                      "WHERE MachineBestandID = @MachineBestandID";
                    deleteCommand = new SqlCommand(deleteStatement, conn);
                    deleteCommand.Parameters.AddWithValue("@MachineBestandID", id);
                    deleteCommand.ExecuteNonQuery();
                }
                foreach (int id in machineId)
                {
                    deleteStatement = "DELETE FROM Machines " +
                                     "WHERE MachineID = @MachineID";
                    deleteCommand = new SqlCommand(deleteStatement, conn);
                    deleteCommand.Parameters.AddWithValue("@MachineID", id);
                    deleteCommand.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
