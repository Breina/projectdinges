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

                ExcelWorksheet worksheetToerental = package.Workbook.Worksheets["n_vast"];
                ExcelWorksheet worksheetKoppel = package.Workbook.Worksheets["m_vast"];
                ExcelWorksheet worksheet = package.Workbook.Worksheets[5];
                string name = worksheet.Name;
                int i = 1;
                int j = 1;
                bool leeg = false;
                string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(connectionString);
                string bestand = newFile.Name.Remove(newFile.Name.IndexOf('.'));

                string insertStatement = "INSERT INTO Bestanden " +
                    "(Bestand) " +
                    "VALUES (@Bestand)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
                insertCommand.Parameters.AddWithValue("@Bestand", name);

                try
                {
                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                    string selectStatement = "SELECT IDENT_CURRENT('Bestanden') FROM Bestanden";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                    int bestandID = Convert.ToInt32(selectCommand.ExecuteScalar());

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
                            decimal waardeToerental = Convert.ToDecimal(worksheetToerental.Cells[i, j].Value);
                            decimal waardeKoppel = Convert.ToDecimal(worksheetKoppel.Cells[i, j].Value);
                            decimal item;
                            if (worksheet.Cells[i, j].Value.Equals("NaN"))
                            {
                                item = 0;
                            }
                            else
                            {
                                item = Convert.ToDecimal(worksheet.Cells[i, j].Value);
                            }

                            insertStatement = "INSERT INTO DataGegevens " +
                           "(BestandID,Gegevens,Toerental,Koppel) " +
                           "VALUES (@BestandID, @Gegevens, @Toerental, @Koppel)";
                            insertCommand = new SqlCommand(insertStatement, conn);
                            insertCommand.Parameters.AddWithValue("@BestandID", bestandID);
                            insertCommand.Parameters.AddWithValue("@Gegevens", item);
                            insertCommand.Parameters.AddWithValue("@Toerental", waardeToerental);
                            insertCommand.Parameters.AddWithValue("@Koppel", waardeKoppel);
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

            string selectStatement = "SELECT Gegevens " +
                "FROM DataGegevens " +
                "WHERE BestandID=@BestandID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@BestandID", 12); // Bestand aanpassen hier!!!!
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
                         string s = reader["Gegevens"].ToString();
                         if (s.Equals("NaN"))
                         {
                             d[x, y] = 0;
                         }
                         else
                         {
                             d[x, y] = Convert.ToDouble(s);
                         }
                     }
                 }
                 

                 /*int i = 0;
                 int j = 0;
                 while (reader.Read())
                 {
                     d[i, j] = Convert.ToDouble(reader["Gegegevens"]);
                     i++;
                     if (i == 41)
                     {
                         i = 0;
                         j++;
                     }
                 }*/
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