using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MotoroziodDB
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
                SqlDataReader reader;

                SqlCommand selectCommand = new SqlCommand();
                SqlCommand selectMaxRendamentIDCommand = new SqlCommand();
                SqlCommand insertInMachinesCommand = new SqlCommand();
                SqlCommand insertInMachineBestandCommand = new SqlCommand();
                SqlCommand insertInRendamentCommand = new SqlCommand();
                SqlCommand insertMaximumRendamentIdCommand = new SqlCommand();

                try
                {

                    int length = (int)package.Workbook.Worksheets.Count;
                    ExcelWorksheet[] worksheets = new ExcelWorksheet[length];
                    string naam;
                    int id;
                    int machineId;
                    int nominaalId;
                    conn.Open();
                    excelTransaction = conn.BeginTransaction();
                    machines = new List<Machine>();
                    insertInMachinesCommand.Connection = conn;
                    insertInMachineBestandCommand.Connection = conn;
                    insertInRendamentCommand.Connection = conn;
                    insertMaximumRendamentIdCommand.Connection = conn;
                    insertInMachinesCommand.Transaction = excelTransaction;
                    insertInMachineBestandCommand.Transaction = excelTransaction;
                    insertInRendamentCommand.Transaction = excelTransaction;
                    insertMaximumRendamentIdCommand.Transaction = excelTransaction;
                    selectCommand.Connection = conn;
                    selectMaxRendamentIDCommand.Connection = conn;
                    selectCommand.Transaction = excelTransaction;
                    selectMaxRendamentIDCommand.Transaction = excelTransaction;
                    insertInMachinesCommand.Parameters.Add("@Naam", SqlDbType.NVarChar);
                    insertInMachineBestandCommand.Parameters.Add("@BestandPad", SqlDbType.NVarChar);
                    insertInMachineBestandCommand.Parameters.Add("@MachineID", SqlDbType.Int);
                    insertInRendamentCommand.Parameters.Add("@MachineBestandID", SqlDbType.Int);
                    insertInRendamentCommand.Parameters.Add("@Rendament", SqlDbType.Decimal);
                    insertInRendamentCommand.Parameters.Add("@NominaalID", SqlDbType.Int);
                    insertMaximumRendamentIdCommand.Parameters.Add("@MachineID", SqlDbType.Int);
                    insertMaximumRendamentIdCommand.Parameters.Add("@BesteNominaalID", SqlDbType.Int);
                    selectMaxRendamentIDCommand.Parameters.Add("@MachineBestandID", SqlDbType.Int);

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
                            machineId = Convert.ToInt32(selectCommand.ExecuteScalar());
                            machines.Add(new Machine(naam, machineId));

                            insertStatement = "INSERT INTO MachineBestand " +
                                "(BestandPad, MachineID) " +
                                "VALUES (@BestandPad, @MachineID)";
                            insertInMachineBestandCommand.CommandText = insertStatement;
                            insertInMachineBestandCommand.Parameters["@BestandPad"].Value = file;
                            insertInMachineBestandCommand.Parameters["@MachineID"].Value = machineId;
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
                            selectStatement = 
                            "SELECT NominaalID,Rendament,MachineBestandID FROM Rendamenten "+                               
                                "WHERE MachineBestandID=@MachineBestandID "+
                                "AND Rendament=(SELECT MAX(Rendament) FROM Rendamenten "+
                                "WHERE MachineBestandID=@MachineBestandID)";


                            selectMaxRendamentIDCommand.CommandText = selectStatement;
                            selectMaxRendamentIDCommand.Parameters["@MachineBestandID"].Value = id;
                            reader = selectMaxRendamentIDCommand.ExecuteReader();
                            reader.Read();
                            nominaalId = Convert.ToInt32(reader["NominaalID"]);                           
                            reader.Close();

                           
                            insertStatement = "UPDATE Machines " +
                                "SET BesteNominaalID=@BesteNominaalID " +
                                "WHERE MachineID = @MachineID";
                            insertMaximumRendamentIdCommand.CommandText = insertStatement;
                            insertMaximumRendamentIdCommand.Parameters["@BesteNominaalID"].Value = nominaalId;
                            insertMaximumRendamentIdCommand.Parameters["@MachineID"].Value=machineId;
                            insertMaximumRendamentIdCommand.ExecuteNonQuery();
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
        /// <param name="bestandPad">tekst</param> 
        /// <param name="file">object van het type FileInfo</param> 
        /// <author>Wim Baens</author> 
        public static void sqlToExcel(string bestandPad, FileInfo file)
        {
            List<Machine> machines = new List<Machine>();
            List<int> machineBestandIds = new List<int>();         
            int tellerId = 0;
            FileInfo newFile = file;

            ExcelPackage package = new ExcelPackage(newFile);

            SqlConnection conn = ConnectionDB.getConnection();

            string selectMachinesStatement = "SELECT Machines.Naam, Machines.MachineID,MachineBestand.MachineBestandID " +
                "FROM Machines INNER JOIN MachineBestand ON Machines.MachineID=MachineBestand.MachineID " +
                "WHERE BestandPad=@BestandPad";
            SqlCommand selectMachinesCommand = new SqlCommand(selectMachinesStatement, conn);
            selectMachinesCommand.Parameters.AddWithValue("@BestandPad", bestandPad);

            string selectRendamentStatement = "SELECT Rendament " +
                "FROM Rendamenten " +
                "WHERE MachineBestandID = @MachineBestandID";
            SqlCommand selectRendamentCommand = new SqlCommand(selectRendamentStatement, conn);
            selectRendamentCommand.Parameters.Add("@MachineBestandID", SqlDbType.Int);

            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = selectMachinesCommand.ExecuteReader();
                while (reader.Read())
                {
                    Machine machine = new Machine(reader["Naam"].ToString(), Convert.ToInt32(reader["MachineID"]));
                    machines.Add(machine);
                    machineBestandIds.Add(Convert.ToInt32(reader["MachineBestandID"].ToString()));
                }
                reader.Close();

                foreach (Machine machine in machines)
                {
                    string machineNaam = machine.MachineNaam;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(machineNaam);
                    selectRendamentCommand.Parameters["@MachineBestandID"].Value = machineBestandIds[tellerId];
                    reader = selectRendamentCommand.ExecuteReader();

                    for (int y = 1; y < 43; y++)
                    {
                        for (int x = 1; x < 43; x++)
                        {
                            reader.Read();
                            double s = Convert.ToDouble(reader["Rendament"]);
                            worksheet.Cells[x, y].Value = s;
                        }
                    }
                    reader.Close();
                    tellerId++;
                }
                reader.Close();
                package.Save();               
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
