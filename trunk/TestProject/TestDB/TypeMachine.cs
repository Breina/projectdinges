using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorozoidDB
{
    /// <summary> 
    /// Klasse om een TypeMachine object voor te stellen 
    /// </summary>
    /// <author>Wim Baens</author>
    public class TypeMachine
    {
        private int typeId;
        private string typeNaam;

        /// <summary> 
        /// Constructor van de klasse TypeMachine
        /// </summary>
        /// <param name="naam">tekst naam</param>  
        /// <param name="typeId">een positief geheel getal</param>  
        /// <author>Wim Baens</author> 
        public TypeMachine(string naam,int typeId)
        {
            this.typeNaam = naam;
            this.typeId = typeId;
        }

        public string TypeNaam
        {
            get { return typeNaam; }
            set { typeNaam = value; }
        }
        
        public int TypeId
        {
            get { return typeId; }
        }

        /// <summary> 
        /// Overschrijven van de toString method
        /// </summary>
        /// <returns>een string</returns>   
        /// <author>Wim Baens</author> 
        public override string ToString()
        {
            return typeNaam;
        }        
    }
}
