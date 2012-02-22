using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TestDB
{
    /// <summary>
    /// Klasse voor excelbestanden in te lezen en uit te lezen
    /// </summary>
    /// <author>Wim Baens</author>
    public static class ExcelDB
    {
        /// <summary> 
        /// schrijft alle data uit de excel weg in de database
        /// </summary>
        /// <param name="pad">string pad file</param> 
        /// <returns>lijst met Machine objecten</returns>
        /// <author>Wim Baens</author>  
        public static List<Machine> excelToSql(string file)
        {
            List<Machine> machines;

            FileInfo newFile = new FileInfo(file);
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int i = 1;
                int j = 1;

                bool leeg = false;
                string selectStatement;

                SqlTransaction excelTransaction = null;
                string insertStatement;
                SqlConnection conn = ConnectionDB.getConnection();

                SqlCommand selectCommand = new SqlCommand();
                SqlCommand insertInMachinesCommand = new SqlCommand();
                SqlCommand insertInMachineBestandCommand = new SqlCommand();
                SqlCommand insertInRendamentCommand = new SqlCommand();

                try
                {

                    int length = (int)package.Workbook.Worksheets.Count;
                    ExcelWorksheet[] worksheets = new ExcelWorksheet[length];
                    string naam;
                    int id;
                    conn.Open();
                    excelTransaction = conn.BeginTransaction();
                    machines = new List<Machine>();
                    insertInMachinesCommand.Connection = conn;
                    insertInMachineBestandCommand.Connection = conn;
                    insertInRendamentCommand.Connection = conn;
                    insertInMachinesCommand.Transaction = excelTransaction;
                    insertInMachineBestandCommand.Transaction = excelTransaction;
                    insertInRendamentCommand.Transaction = excelTransaction;
                    selectCommand.Connection = conn;
                    selectCommand.Transaction = excelTransaction;
                    insertInMachinesCommand.Parameters.Add("@Naam", SqlDbType.NVarChar);
                    insertInMachineBestandCommand.Parameters.Add("@BestandPad", SqlDbType.NVarChar);
                    insertInMachineBestandCommand.Parameters.Add("@MachineID", SqlDbType.Int);
                    insertInRendamentCommand.Parameters.Add("@MachineBestandID", SqlDbType.Int);
                    insertInRendamentCommand.Parameters.Add("@Rendament", SqlDbType.Decimal);
                    insertInRendamentCommand.Parameters.Add("@NominaalID", SqlDbType.Int);

                    for (int k = 1; k <= length; k++)
                    {
                        leeg = false;
                        i = 1;
                        j = 1;
                        int nominaal = 1;
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[k];


                        naam = worksheet.Name;
                        if (!naam.Equals("uitleg") && !naam.Equals("n_vast") && !naam.Equals("m_vast"))
                        {
                            insertStatement = "INSERT INTO Machines " +
                                "(Naam) " +
                                "VALUES (@Naam)";

                            insertInMachinesCommand.CommandText = insertStatement;
                            insertInMachinesCommand.Parameters["@Naam"].Value = naam;
                            insertInMachinesCommand.ExecuteNonQuery();

                            selectStatement = "SELECT IDENT_CURRENT('Machines') FROM Machines";
                            selectCommand.CommandText = selectStatement;
                            id = Convert.ToInt32(selectCommand.ExecuteScalar());
                            machines.Add(new Machine(naam, id));

                            insertStatement = "INSERT INTO MachineBestand " +
                                "(BestandPad, MachineID) " +
                                "VALUES (@BestandPad, @MachineID)";
                            insertInMachineBestandCommand.CommandText = insertStatement;
                            insertInMachineBestandCommand.Parameters["@BestandPad"].Value = file;
                            insertInMachineBestandCommand.Parameters["@MachineID"].Value = id;
                            insertInMachineBestandCommand.ExecuteNonQuery();

                            selectStatement = "SELECT IDENT_CURRENT('MachineBestand') FROM MachineBestand";
                            selectCommand.CommandText = selectStatement;
                            id = Convert.ToInt32(selectCommand.ExecuteScalar());

                            insertStatement = "INSERT INTO Rendamenten " +
                                    "(MachineBestandID, Rendament,NominaalID) " +
                                    "VALUES (@MachineBestandID, @Rendament,@NominaalID)";

                            insertInRendamentCommand.CommandText = insertStatement;

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
                                    insertInRendamentCommand.Parameters["@MachineBestandID"].Value = id;
                                    insertInRendamentCommand.Parameters["@Rendament"].Value = item;
                                    insertInRendamentCommand.Parameters["@NominaalID"].Value = nominaal;
                                    insertInRendamentCommand.ExecuteNonQuery();
                                    i++;
                                    nominaal++;
                                }
                            }
                            if (nominaal != 1765 || j != 43)
                            {
                                throw new Exception();
                            }
                        }
                    }
                    excelTransaction.Commit();
                }
                catch (Exception ex)
                {
                    if (excelTransaction != null)
                    {
                        excelTransaction.Rollback();
                    }
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }

            return machines;
        }

        /// <summary> 
        /// haalt gegevens op uit de database en schrijft deze in een excel
        /// </summary>
        /// <param name="pad">string pad file</param> 
        /// <returns>false als het mislukt, true als het lukt</returns>
        /// <author>Wim Baens</author> 
        public static bool sqlToExcel(string nummer, string adres)
        {
            List<string> list = new List<string>();
            bool gelukt = false;

            SqlConnection conn = ConnectionDB.getConnection();

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
                    gelukt = true;

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
            return gelukt;

        }


    }
}