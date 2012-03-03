using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorozoidDB
{
    /// <summary>
    /// Klasse om een Points object voor te stellen
    /// </summary>
    /// <author>Wim Baens</author>
   public class Points
    {
        private double koppel;
        private double toerental;

        /// <summary> 
        /// Constructor van de klasse Points
        /// </summary>
        /// <param name="toerental">een kommagetal</param>  
        /// <param name="koppel">een kommagetal</param>  
        /// <author>Wim Baens en Brecht Derwael</author> 
        public Points(double toerental, double koppel)
        {
            this.toerental = toerental;
            this.koppel = koppel;
        }
        public double getToerental()
        {
            return toerental;
        }

        public void setToerental(double toerental)
        {
            this.toerental = toerental;
        }

        public double getKoppel()
        {
            return koppel;
        }

        public void setKoppel(double koppel)
        {
            this.koppel = koppel;
        }
    }
}
