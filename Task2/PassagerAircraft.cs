using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    internal class PassengerAircraft : Aircraft, IMaintenance
    {
        private int number_of_places;
        private int number_of_passagers;
        private double pass_total_weith_of_bagages_kg;
    
        public int Number_of_places
        {
            get { return number_of_places; }
            set { number_of_places = value; }
        }
        public int Number_of_passagers
        {
            get { return number_of_passagers; }
            set { number_of_passagers = value; }
        }
        public double Pass_total_weith_of_bagages_kg
        {
            get { return pass_total_weith_of_bagages_kg; }
            set { pass_total_weith_of_bagages_kg = value; }
        }
        public PassengerAircraft()
        {
            this.Name = "Unknown";
            this.air_type = "passengerAircraft";
            this.number_of_passagers = 0;
            this.Air_total_weith_of_bagages_kg = 0;
            this.pass_total_weith_of_bagages_kg = 0;
        }
        public PassengerAircraft(string name, int number_of_passagers, double pass_total_weith_of_bagages_kg)
        {
            this.Name = name;
            this.number_of_passagers = number_of_passagers;
            this.number_of_places = 150;
            this.pass_total_weith_of_bagages_kg = pass_total_weith_of_bagages_kg;
            this.Air_total_weith_of_bagages_kg = 500;
        }
        // Maintenance
        // Check if there is at least one person at the airport before the aircraft lands
        public bool Check_if_passenger_to_theAirport()
        {
            if (number_of_passagers > 0 && number_of_passagers <= number_of_places) return true;
            else return false;
        }
        // Check if there is no probleme with passengers's bagages before the aircraft goes
        public bool Check_bagages()
        {
            if (pass_total_weith_of_bagages_kg > Air_total_weith_of_bagages_kg) return false;
            else return true;
        }
        // Add passengers in the plane
        public bool Add_passengers(int additional_passengers)
        {
            if ((number_of_passagers + additional_passengers) < number_of_places)
            {
                number_of_passagers += additional_passengers;
                return true;
            }
            else return false;
        }
        // Remove passengers from the plane
        public bool Remove_passengers(int passenger_to_remove)
        {
            if (number_of_passagers - passenger_to_remove > 0)
            {
                number_of_passagers -= passenger_to_remove;
                return true;
            }
            else return false;
        }
        // Add bagages in the plane
        public bool Add_bagages(double additional_bagages)
        {
            if ((pass_total_weith_of_bagages_kg + additional_bagages) < Air_total_weith_of_bagages_kg)
            {
                pass_total_weith_of_bagages_kg += additional_bagages;
                return true;
            }
            else return false;
        }
        // Remove bagages from the plane
        public bool Remove_bagages(double bagages_to_remove_kg)
        {
            if (pass_total_weith_of_bagages_kg - bagages_to_remove_kg > 0)
            {
                pass_total_weith_of_bagages_kg -= bagages_to_remove_kg;
                return true;
            }
            else return false;
        }
    }
}