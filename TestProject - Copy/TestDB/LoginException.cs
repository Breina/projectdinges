using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotoroziodDB
{
    /// <summary>
    /// Exceptionklasse voor als het inloggen mislukt
    /// </summary>
    /// <author>Wim Baens</author>
   public class LoginException : Exception
    {
        /// <summary> 
        /// constructor om een boodschap door te geven aan de base klasse Exception
        /// </summary>
        /// <param name="message">tekst message</param>       
        /// <author>Wim Baens</author> 
       public LoginException(string message):base(message){}     
       
    }
}
