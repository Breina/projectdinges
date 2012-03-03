using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MotorozoidDB
{
    public class ProductieMachineDB
    {

        public static List<ProductieMachine> getProductieMachines()
        {
            List<ProductieMachine> productieMachines = new List<ProductieMachine>();

            SqlConnection conn = ConnectionDB.getConnection();
            string selectStatement;
            SqlCommand selectCommand;

            selectStatement = "SELECT ProductieMachineNaam,ProductieMachineID " +
                            "FROM ProductieMachines " +
                            "ORDER BY ProductieMachineID";
            selectCommand = new SqlCommand(selectStatement, conn);


            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    productieMachines.Add(new ProductieMachine(Convert.ToInt32(reader["ProductieMachineID"])-1, reader["ProductieMachineNaam"].ToString()));
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

            return productieMachines;
        }

        public static void addProductieMachine(string naam)
        {
            List<ProductieMachine> productieMachines = new List<ProductieMachine>();

            SqlConnection conn = ConnectionDB.getConnection();
            string insertStatement;
            string selectStatement;
            SqlCommand insertCommand;
            SqlCommand selectCommand;
            SqlDataReader reader;

            selectStatement = "SELECT * FROM ProductieMachines " +
                "WHERE ProductieMachineNaam=@ProductieMachineNaam";
            selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@ProductieMachineNaam", naam);

            insertStatement = "INSERT INTO ProductieMachines (ProductieMachineNaam)" +
                            "VALUES(@ProductieMachineNaam) ";
            insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@ProductieMachineNaam", naam);


            try
            {
                conn.Open();
                reader = selectCommand.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    insertCommand.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    throw new Exception("Productiemachine bestaat al! Geef een andere naam in.");
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public static void updateProductieMachine(ProductieMachine machine)
        {
            

            SqlConnection conn = ConnectionDB.getConnection();
            string updateStatement;
            string selectStatement;
            SqlCommand updateCommand;
            SqlCommand selectCommand;
            SqlDataReader reader;

            selectStatement = "SELECT * FROM ProductieMachines " +
                "WHERE ProductieMachineNaam=@ProductieMachineNaam";
            selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@ProductieMachineNaam", machine.ProductieMachineNaam);

            updateStatement = "UPDATE ProductieMachines " +
            "SET ProductieMachineNaam=@ProductieMachineNaam " +
            "WHERE ProductieMachineID=@ProductieMachineID";
            updateCommand = new SqlCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@ProductieMachineNaam", machine.ProductieMachineNaam);
            updateCommand.Parameters.AddWithValue("@ProductieMachineID", machine.ProductieMachineID);


            try
            {
                conn.Open();
                reader = selectCommand.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    throw new Exception("Productiemachine bestaat al! Geef een andere naam in.");
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public static void verwijderProductieMachine(ProductieMachine machine)
        {
            

            SqlConnection conn = ConnectionDB.getConnection();
            string verwijderStatement;
            string updateStatement;
           
            SqlCommand verwijderCommand;
            SqlCommand updateCommand;
           
          

            updateStatement = "UPDATE MachineBestand " +
            "SET ProductieMachineID=@NieuweProductieMachineID " +           
            "WHERE ProductieMachineID=@OudeProductieMachineID";
            updateCommand = new SqlCommand(updateStatement, conn);          
            updateCommand.Parameters.AddWithValue("@NieuweProductieMachineID", 1);
            updateCommand.Parameters.AddWithValue("@OudeProductieMachineID", machine.ProductieMachineID);

            verwijderStatement = "DELETE ProductieMachines " +
            "WHERE ProductieMachineID=@ProductieMachineID";
            verwijderCommand = new SqlCommand(verwijderStatement, conn);          
            verwijderCommand.Parameters.AddWithValue("@ProductieMachineID", machine.ProductieMachineID);


            try
            {
                conn.Open();
                updateCommand.ExecuteNonQuery();
                verwijderCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
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
