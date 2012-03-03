using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MotorozoidDB
{
    /// <summary>
    /// Klasse om de logingegevens te controleren
    /// </summary>
    /// <author>Wim Baens</author>
   public class LoginDB
    {
        /// <summary> 
        /// controleert of het wachtwoord en paswoord kloppen
        /// </summary>
        /// <param name="login">tekst login</param> 
         /// <param name="password">tekst password</param> 
        /// <returns>true als het inloggen lukt, false als het niet lukt</returns>
        /// <author>Wim Baens</author>  
       public static bool inloggen(string login, string password)
       {
           bool inloggen = false;
           string wachtwoord;

           SqlConnection conn = ConnectionDB.getConnection();

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
                       throw new LoginException("Wachtwoord niet correct! Probeer opnieuw.");
                   }

               }
               else
               {
                   throw new LoginException("Login naam bestaat niet! Probeer opnieuw.");
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
           return inloggen;
       }
    }
}
