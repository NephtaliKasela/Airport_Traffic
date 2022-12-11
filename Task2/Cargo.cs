using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    internal class Cargo : Aircraft, IMaintenance
    {
        public double bagages_kg;
        public Cargo()
        {
            this.Name = "Unknown";
            this.air_type = "cargo";
            this.Air_total_weith_of_bagages_kg = 0;
        }
        public Cargo(string name, double bagages)
        {
            this.Name = name;
            this.bagages_kg = bagages;
            this.Air_total_weith_of_bagages_kg = 60;
        }
        // Maintenace
        // Check if there are bagages at the airport before the aircraft lands
        public bool Check_if_bagages_to_theAirport()
        { 
            if (bagages_kg > 0) return true;
            else return false;
           
        }
        // Check if there is no probleme with bagages before the aircraft goes
        public bool Check_bagages()
        {
            if (bagages_kg > Air_total_weith_of_bagages_kg) return false;
            else return true;
        }
        // Add bagages in the plane
        public bool Add_bagages(double additional_bagages)
        {
            if ((bagages_kg + additional_bagages) < Air_total_weith_of_bagages_kg)
            {
                bagages_kg += additional_bagages;
                return true;
            }
            else return false;
        }
        // Remove bagages from the plane
        public bool Remove_bagages(double bagages_to_remove_kg)
        {
            if (bagages_kg - bagages_to_remove_kg > 0)
            {
                bagages_kg -= bagages_to_remove_kg;
                return true;
            }
            else return false;
        }
    }
}