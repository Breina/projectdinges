using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace TestDB
{
    public class TestDB1
    {
        public void excelToSql(string file)
        {
            FileInfo newFile = new FileInfo(file);
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[6];
                string name = worksheet.Name;
                int i = 1;
                int j = 1;
                bool leeg = false;
                string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;
                string selectStatement;
                SqlCommand insertCommand;
                SqlCommand selectCommand;

                SqlConnection conn = new SqlConnection(connectionString);
                string bestand = newFile.Name.Remove(newFile.Name.IndexOf('.'));

                string insertStatement = "INSERT INTO Bestanden " +
                    "(BestandNaam) " +
                    "VALUES (@BestandNaam)";

                insertCommand = new SqlCommand(insertStatement, conn);
                insertCommand.Parameters.AddWithValue("@BestandNaam", name);
                try
                {
                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                    selectStatement = "SELECT IDENT_CURRENT('Bestanden') FROM Bestanden";
                    selectCommand = new SqlCommand(selectStatement, conn);
                    int bestandID = Convert.ToInt32(selectCommand.ExecuteScalar());

                    insertStatement = "INSERT INTO Gegevens " +
                        "(BestandID) " +
                        "VALUES (@BestandID)";

                    insertCommand = new SqlCommand(insertStatement, conn);
                    insertCommand.Parameters.AddWithValue("@BestandID", bestandID);
                    insertCommand.ExecuteNonQuery();

                    selectStatement = "SELECT IDENT_CURRENT('Gegevens') FROM Gegevens";
                    selectCommand = new SqlCommand(selectStatement, conn);
                    int gegevensID = Convert.ToInt32(selectCommand.ExecuteScalar());

                    while (!leeg)
                    {

                        if (worksheet.Cells[1, j].Value == null)
                        {
                            leeg = true;
                        }
                        else if (worksheet.Cells[i, j].Value == null)
                        {
                            j++;
                            i = 1;
                        }
                        else
                        {                           
                            double item;
                            if (worksheet.Cells[i, j].Value.Equals("NaN"))
                            {
                                item = 0;
                            }
                            else
                            {
                                item = Convert.ToDouble(worksheet.Cells[i, j].Value);
                            }                          
                            insertStatement = "INSERT INTO DataGegevens " +
                            "(GegevensID,Rendament) " +
                            "VALUES (@GegevensID, @Rendament)";
                          
                            insertCommand = new SqlCommand(insertStatement, conn);
                            insertCommand.Parameters.AddWithValue("@GegevensID", gegevensID);
                            insertCommand.Parameters.AddWithValue("@Rendament", item);                           
                            insertCommand.ExecuteNonQuery();                        
                            i++;
                        }
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

        public List<string> sqlToExcel(string nummer, string adres)
        {
            List<string> list = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            string selectStatement = "SELECT Gegevens " +
                "FROM DataGegevens " +
                "WHERE BestandID=@BestandID ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@BestandID", nummer);

            string selectStatement2 = "SELECT Bestand " +
                "FROM Bestanden " +
                "WHERE ID = @ID";
            SqlCommand selectCommand2 = new SqlCommand(selectStatement2, conn);
            selectCommand2.Parameters.AddWithValue("@ID", nummer);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = selectCommand2.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    string bestand = reader["Bestand"].ToString();
                    FileInfo newFile = new FileInfo(adres + "\\" + bestand + ".xlsx");
                    reader.Close();
                    reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["Gegevens"].ToString());
                    }
                    reader.Close();
                    ExcelPackage package = new ExcelPackage(newFile);
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("gegevens");
                    int i = 1;
                    int j = 1;
                    foreach (var item in list)
                    {
                        if (item != "NaN")
                        {
                            worksheet.Cells[i, j].Value = Convert.ToDouble(item);
                        }
                        else
                        {
                            worksheet.Cells[i, j].Value = item;

                        }
                        j++;
                    }
                    package.Save();

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
            return list;
        }

        public double[,] getData()
        {
            double[,] d = new double[42, 42];

            string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            string selectStatement = "SELECT GegevenID " +
                "FROM Gegevens " +
                "WHERE BestandID=@BestandID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@BestandID", 20); // Bestand aanpassen hier!!!!
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = selectCommand.ExecuteReader();
                reader.Read();

                int gegevensID = Convert.ToInt32(reader["GegevenID"]);
                reader.Close();
                selectStatement = "SELECT Rendament " +
                "FROM DataGegevens " +
                "WHERE GegevensID=@GegevensID";
                selectCommand = new SqlCommand(selectStatement, conn);
                selectCommand.Parameters.AddWithValue("@GegevensID", gegevensID);
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

        public Points[,] getValues()
        {
            Points[,] d = new Points[42, 42];

            string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            string selectStatement = "SELECT Toerental, Koppel " +
                "FROM NominaleWaarden";
                
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

        public bool inloggen(string login, string password)
        {
            bool inloggen = false ;
            string wachtwoord;
            string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            string selectStatement = "SELECT Login,Password " +
                "FROM Users " +
                "WHERE Login=@Login";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@Login", login); // Bestand aanpassen hier!!!!
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    wachtwoord = reader["Password"].ToString();
                    if (wachtwoord.Equals(password))
                    {
                        inloggen = true;
                    }
                    else
                    {
                        throw new Exception("Wachtwoord niet correct! Probeer opnieuw.");
                    }

                }
                else
                {
                    throw new Exception("Login naam bestaat niet! Probeer opnieuw.");
                }

            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
               
                conn.Close();
            }
            return inloggen;
        }
    }
}