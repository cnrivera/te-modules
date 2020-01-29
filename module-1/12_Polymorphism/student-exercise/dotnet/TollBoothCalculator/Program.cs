using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicleTolls = new List<IVehicle>();

            vehicleTolls.Add(new Car(false));
            vehicleTolls.Add(new Car(true));
            vehicleTolls.Add(new Tank());
            vehicleTolls.Add(new Truck(4));
            vehicleTolls.Add(new Truck(6));
            vehicleTolls.Add(new Truck(8));

            Random random = new Random();
            int totalMiles = 0;
            double totalRevenue = 0;

            Console.WriteLine("{0, -20} {1, 10} {2, 14}", "Vehicle", "Distance Traveled", "Toll $");
            Console.WriteLine("-----------------------------------------------------");
            foreach (IVehicle vehicle in vehicleTolls)
            {
                int distance = random.Next(10, 240);
                totalMiles += distance;
                totalRevenue += vehicle.CalculateToll(distance);

                Console.WriteLine("{0,-20} {1,10} {2,20:C}", vehicle, distance, vehicle.CalculateToll(distance));
               
            }
            
            Console.WriteLine("");
            Console.WriteLine($"Total Miles Traveled: {totalMiles}");
            Console.WriteLine("Total TollBooth Revenue: " + "{0:C}", totalRevenue);
            
        }
    }
}
