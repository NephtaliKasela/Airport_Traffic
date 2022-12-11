using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{                                                           // gregor
    internal class Aircraft
    {
        private string name = String.Empty;
        public string air_type = String.Empty;
        
        private double air_total_weith_of_bagages_kg;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Air_total_weith_of_bagages_kg
        {
            get { return air_total_weith_of_bagages_kg;}
            set { air_total_weith_of_bagages_kg = value; }
        }
    }
}
