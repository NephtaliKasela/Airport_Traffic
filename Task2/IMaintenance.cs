using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    internal interface IMaintenance
    { 
        public bool Check_bagages();
        public bool Add_bagages(double additional_bagages);
        public bool Remove_bagages(double bagages_to_remove_kg);
    }
}