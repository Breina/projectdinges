using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TestDB
{
    /// <summary>
    /// Klasse alle data op te halen die nodig is om de grafiek te tekenen
    /// </summary>
    /// <author>Wim Baens</author>
  public class TekenDB
    {
        /// <summary> 
        /// Haalt de rendamenten op van het geselecteerde bestand en de machine
        /// </summary>
        /// <param name="pad">tekst</param> 
        /// <param name="machineID">positief geheel getal</param> 
        /// <returns>een array van double objecten</returns>
        /// <author>Brecht Derwael en Wim Baens</author> 
        public static double[,] getData(string pad, int machineID)
        {
            double[,] d = new double[42, 42];

            SqlConnection conn = ConnectionDB.getConnection();

            string selectStatement = "SELECT MachineBestandID " +
                "FROM MachineBestand " +
                "WHERE BestandPad=@BestandPad " +
                "AND MachineID=@MachineID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@BestandPad", pad);
            selectCommand.Parameters.AddWithValue("@MachineID", machineID);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = selectCommand.ExecuteReader();
                reader.Read();

                int machineBestandID = Convert.ToInt32(reader["MachineBestandID"]);
                reader.Close();
                selectStatement = "SELECT Rendament " +
                "FROM Rendamenten " +
                "WHERE MachineBestandID=@MachineBestandID " +
                "ORDER BY NominaalID";
                selectCommand = new SqlCommand(selectStatement, conn);
                selectCommand.Parameters.AddWithValue("@MachineBestandID", machineBestandID);
                reader = selectCommand.ExecuteReader();

                for (int y = 0; y < 42; y++)
                {
                    for (int x = 41; x >= 0; x--)
                    {
                        reader.Read();
                        double s = Convert.ToDouble(reader["Rendament"]);

                        d[x, y] = s;

                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return d;

        }
        /// <summary> 
        /// Haalt Points Objecten op uit de NominaleWaarden tabel van de database
        /// </summary>       
        /// <returns>een array van Points objecten</returns>
        /// <author>Brecht Derwael en Wim Baens</author> 
        public static Points[,] getValues()
        {
            Points[,] d = new Points[42, 42];

            SqlConnection conn = ConnectionDB.getConnection();

            string selectStatement = "SELECT Toerental, Koppel " +
                "FROM NominaleWaarden " +
                "ORDER BY NominaalID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();

                reader = selectCommand.ExecuteReader();

                for (int y = 0; y < 42; y++)
                {
                    for (int x = 41; x >= 0; x--)
                    {
                        reader.Read();
                        double t = Convert.ToDouble(reader["Toerental"]);
                        double k = Convert.ToDouble(reader["Koppel"]);

                        d[x, y] = new Points(t, k);
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return d;

        }     
    }
}
