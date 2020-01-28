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
           


            Console.WriteLine("Vehicle                   Distance Traveled                 Toll $");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (IVehicle vehicle in vehicleTolls)
            {
                int distance = random.Next(10, 240);

                Console.WriteLine($"{vehicle}                 {distance}                  ${vehicle.CalculateToll(distance)}");
            }
        }
    }
}
