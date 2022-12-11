using System;

namespace Airport // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's create a object of type passengerAircraft
            PassengerAircraft plane = new PassengerAircraft("Congo Airline", 101, 258.27);
            // Maintenance
            if (plane.Check_if_passenger_to_theAirport())
            {
                Console.WriteLine("The plane can land...");
                if (plane.Check_bagages())
                {
                    Console.WriteLine("The plane can leave the airport...");
                    Console.WriteLine($"The plane has gone with {plane.Number_of_passagers} passenger(s) and {plane.Pass_total_weith_of_bagages_kg} Kg of bagages.");
                }
                else
                {
                    Console.WriteLine("The plane can not leave actually.");
                    Console.WriteLine("Something is wrong with bagages...");
                }
            }
            else Console.WriteLine("Something is wrong with passengers...");

            plane.Add_passengers(20);
            plane.Remove_passengers(20);

            plane.Add_bagages(10);
            plane.Remove_bagages(10);

            int available_place_passenger = plane.Number_of_places - plane.Number_of_passagers;
            double available_place_bagages = Math.Round(plane.Air_total_weith_of_bagages_kg - plane.Pass_total_weith_of_bagages_kg);
            Console.WriteLine($"Available place of passengers : {available_place_passenger}");
            Console.WriteLine($"Available place of bagages    : {available_place_bagages}");
        }
    }
}