using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorozoidDB
{
    /// <summary> 
    /// Klasse om een Machine object voor te stellen 
    /// </summary>
    /// <author>Wim Baens en Brecht Derwael</author>
    public class Machine
    {
        private int machineId;
        private string machineNaam;     
        private int typeId;
        private string label;
        private double vermogen;
        private double nominaalToerental;
        private double nominaalKoppel;
        private int besteNominaalID;
        private int productieMachineID;        

        /// <summary> 
        /// Constructor van de klasse Machine
        /// </summary>
        /// <param name="naam">tekst naam</param>  
        /// <param name="id">een positief geheel getal</param>  
        /// <author>Wim Baens en Brecht Derwael</author> 
        public Machine(string naam, int id)
        {
            this.machineId = id;
            this.machineNaam = naam;
        }
        
        public string MachineNaam
        {
            get { return machineNaam; }
            set { machineNaam = value; }
        }

        public double NominaalKoppel
        {
            get { return nominaalKoppel; }
            set { nominaalKoppel = value; }
        }

        public double NominaalToerental
        {
            get { return nominaalToerental; }
            set { nominaalToerental = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public double Vermogen
        {
            get { return vermogen; }
            set { vermogen = value; }
        }

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

        public int MachineId
        {
            get { return machineId; }
        }

        public int BesteNominaalID
        {
            get { return besteNominaalID; }
            set { besteNominaalID = value; }
        }

        public int ProductieMachineID
        {
            get { return productieMachineID; }
            set { productieMachineID = value; }
        }

        /// <summary> 
        /// Overschrijven van de toString method
        /// </summary>
        /// <returns>een string</returns>   
        /// <author>Wim Baens</author> 
        public override string ToString()
        {
            return machineNaam;
        }
    }
}
