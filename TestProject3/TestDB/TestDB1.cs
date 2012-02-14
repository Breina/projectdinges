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
    public static class TestDB1
    {


        public static Machine[] excelToSql(string file)
        {
            Machine[] machines;

            FileInfo newFile = new FileInfo(file);
            using (ExcelPackage package = new ExcelPackage(newFile))
            {         
                int i = 1;
                int j = 1;
                bool leeg = false;
                string selectStatement;
                SqlCommand insertCommand;
                SqlCommand selectCommand;
                String insertStatement;
                SqlConnection conn = DataTestDB.getConnection();

                try
                {                    
                    int length = package.Workbook.Worksheets.Count;
                    ExcelWorksheet[] worksheets = new ExcelWorksheet[length];
                    string naam;
                    int id;
                    conn.Open();
                    machines = new Machine[length - 3];

                    for (int k = 4; k <= length; k++)
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[k];

                        naam = worksheet.Name;

                        insertStatement = "INSERT INTO Machine " +
                            "(Naam) " +
                            "VALUES (@Naam)";

                        insertCommand = new SqlCommand(insertStatement, conn);
                        insertCommand.Parameters.AddWithValue("@Naam", naam);
                        insertCommand.ExecuteNonQuery();

                        selectStatement = "SELECT IDENT_CURRENT('Machine') FROM Machine";
                        selectCommand = new SqlCommand(selectStatement, conn);
                        id = Convert.ToInt32(selectCommand.ExecuteScalar());
                        machines[k - 4] = new Machine(naam, id);

                        insertStatement = "INSERT INTO Gegevens " +
                            "(BestandPad, MachineID) " +
                            "VALUES (@BestandPad, @MachineID)";

                        insertCommand = new SqlCommand(insertStatement, conn);
                        insertCommand.Parameters.AddWithValue("@BestandPad", file);
                        insertCommand.Parameters.AddWithValue("@MachineID", id);
                        insertCommand.ExecuteNonQuery();

                        selectStatement = "SELECT IDENT_CURRENT('Gegevens') FROM Gegevens";
                        selectCommand = new SqlCommand(selectStatement, conn);
                        id = Convert.ToInt32(selectCommand.ExecuteScalar());

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
                                insertCommand.Parameters.AddWithValue("@GegevensID", id);
                                insertCommand.Parameters.AddWithValue("@Rendament", item);
                                insertCommand.ExecuteNonQuery();
                                i++;
                            }
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

            return machines;
        }

        public static List<string> sqlToExcel(string nummer, string adres)
        {
            List<string> list = new List<string>();


            SqlConnection conn = DataTestDB.getConnection();

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

        public static double[,] getData()
        {
            double[,] d = new double[42, 42];

            SqlConnection conn = DataTestDB.getConnection();

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

        public static Points[,] getValues()
        {
            Points[,] d = new Points[42, 42];

            SqlConnection conn = DataTestDB.getConnection();

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

        public static bool inloggen(string login, string password)
        {
            bool inloggen = false ;
            string wachtwoord;

            SqlConnection conn = DataTestDB.getConnection();

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

        public static void writeMachineData(Machine[] machines)
        {
            SqlCommand updateCommand;
            String updateStatement;
            SqlConnection conn = DataTestDB.getConnection();

            try
            {
                conn.Open();

                foreach (Machine m in machines)
                {
                    updateStatement = "UPDATE Machine " +
                                    "SET TypeId = @TypeID, " +
                                    "Label = @Label, " +
                                    "Vermogen = @Vermogen, " +
                                    "Tnom = @Tnom, " +
                                    "Nnom = @Nnom " +
                                    "WHERE MachineID = @MachineID";
                    updateCommand = new SqlCommand(updateStatement, conn);
                    updateCommand.Parameters.AddWithValue("@TypeID", m.getType());
                    updateCommand.Parameters.AddWithValue("@Label", m.getLabel());
                    updateCommand.Parameters.AddWithValue("@Vermogen", m.getVermogen());
                    updateCommand.Parameters.AddWithValue("@Tnom", m.getKoppel());
                    updateCommand.Parameters.AddWithValue("@Nnom", m.getToerental());
                    updateCommand.Parameters.AddWithValue("@MachineID", m.getId());

                    updateCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                // Messagebox fzo eh
            }
            finally
            {
                conn.Close();
            }
        }
    }
}