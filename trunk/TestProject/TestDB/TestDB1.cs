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
        public List<string> excelToSql(string file)
        {

            FileInfo newFile = new FileInfo(file);
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                List<string> list = new List<string>();
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int i = 1;
                int j = 1;
                bool leeg = false;

                while (!leeg)
                {

                    if (worksheet.Cells[i, 1].Value == null)
                    {
                        leeg = true;
                    }
                    else if (worksheet.Cells[i, j].Value == null)
                    {
                        i++;
                        j = 1;
                    }
                    else
                    {
                        list.Add(worksheet.Cells[i, j].Value.ToString());

                        j++;

                    }
                }


                string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(connectionString);

                string h = "hallo";
                string insertStatement = "INSERT INTO Bestanden " +
                    "(Bestand) " +
                    "VALUES (@Bestand)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
                insertCommand.Parameters.AddWithValue("@Bestand", h);
                try
                {
                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                    string selectStatement = "SELECT IDENT_CURRENT('Bestanden') FROM Bestanden";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                    int id = Convert.ToInt32(selectCommand.ExecuteScalar());


                    foreach (var item in list)
                    {
                        insertStatement = "INSERT INTO DataGegevens " +
                        "(ID,Gegevens) " +
                        "VALUES(@ID, @Gegevens)";
                        insertCommand = new SqlCommand(insertStatement, conn);
                        insertCommand.Parameters.AddWithValue("@ID", id);
                        insertCommand.Parameters.AddWithValue("@Gegevens", item);
                        insertCommand.ExecuteNonQuery();
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
        }

        public List<string> sqlToExcel(string nummer, string adres)
        {
            List<string> list = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["dataTESTConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            string selectStatement = "SELECT Gegevens " +
                "FROM DataGegevens " +
                "WHERE ID=@ID ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@ID", nummer);

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
                        worksheet.Cells[i, j].Value = Convert.ToDouble(item);
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
    }
}
