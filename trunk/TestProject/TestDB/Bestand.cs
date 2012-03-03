using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorozoidDB
{
    /// <summary> 
    /// Klasse om een Bestand object voor te stellen 
    /// </summary>
    /// <author>Wim Baens</author>
    public class Bestand
    {
        private string pad;

        /// <summary> 
        /// Constructor van de klasse Bestand
        /// </summary>
        /// <param name="pad">string pad file</param>     
        /// <author>Wim Baens</author>    
        public Bestand(string pad)
        {
            this.pad = pad;

        }

        public string Pad
        {
            get { return pad; }
            set { pad = value; }
        }


        /// <summary> 
        /// Overschrijven van de toString method
        /// </summary>
        /// <returns>een string</returns>   
        /// <author>Wim Baens</author> 
        public override string ToString()
        {
            return pad;
        }
    }
}
