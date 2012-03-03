using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorozoidDB
{

    /// <summary> 
    /// Klasse om een ProductieMachine object voor te stellen 
    /// </summary>
    /// <author>Wim Baens</author>
    public class ProductieMachine
    {
        private int productieMachineID;
        private string productieMachineNaam;

        /// <summary> 
        /// Constructor van de klasse ProductieMachine
        /// </summary>      
        /// <param name="productieMachineID">een positief geheel getal</param>  
        /// <param name="productieMachineNaam">tekst naam</param>  
        /// <author>Wim Baens</author> 
        public ProductieMachine(int productieMachineID, string productieMachineNaam)
        {
            this.productieMachineID = productieMachineID;
            this.productieMachineNaam = productieMachineNaam;
        }

        public int ProductieMachineID
        {
            get { return productieMachineID; }
            set { productieMachineID = value; }
        }

        public string ProductieMachineNaam
        {
            get { return productieMachineNaam; }
            set { productieMachineNaam = value; }
        }

        /// <summary> 
        /// Overschrijven van de toString method
        /// </summary>
        /// <returns>een string</returns>   
        /// <author>Wim Baens</author> 
        public override string ToString()
        {
            return productieMachineNaam;
        }        
    }
}
