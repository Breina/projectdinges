using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDB
{
   public class Points
    {
        private double koppel;
        private double toerental;


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
