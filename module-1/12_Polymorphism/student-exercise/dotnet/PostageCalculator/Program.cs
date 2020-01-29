using System;
using System.Collections.Generic;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IDeliveryDriver> deliveryMethods = new List<IDeliveryDriver>();

            deliveryMethods.Add(new PostalFirst());
            deliveryMethods.Add(new PostalSecond());
            deliveryMethods.Add(new PostalThird());
            deliveryMethods.Add(new FexEd());
            deliveryMethods.Add(new SPUFourDay());
            deliveryMethods.Add(new SPUTwoDay());
            deliveryMethods.Add(new SPUNextDay());
            
            


            Console.Write("Please enter the weight of the package: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("(P)ounds or (O)unces? ".ToLower());
            string weightType = Console.ReadLine();

            if (weightType == "p")
            {
                weight *= 16;
            }

            Console.Write("What distance will it be traveling? ");
            
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("{0,-20} {1,35}", "Delivery Method", "$ cost");
            Console.WriteLine("------------------------------------------------------------------");
            foreach (IDeliveryDriver method in deliveryMethods)
            {
                double rate = method.CalculateRate(distance, weight);
                Console.WriteLine("{0,-40} {1,15:C}", method, rate);
                
            }
            

            
            

        }
    }
}
