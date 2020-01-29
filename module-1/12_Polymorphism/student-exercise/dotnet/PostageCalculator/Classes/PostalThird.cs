using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalThird : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;

                //ounces
                if (weight <= 2)
                {
                    rate = 0.0020 * distance;
                }
                else if (weight <= 8)
                {
                    rate = 0.0022 * distance;
                }
                else if (weight <= 15)
                {
                    rate = 0.0024 * distance;
                }
            
                //pounds
                else if (weight <= 3*16)
                {
                    rate = 0.0150 * distance;
                }
                else if (weight <= 8*16)
                {
                    rate = 0.0160 * distance;
                }
                else if (weight > 8*16)
                {
                    rate = 0.0170 * distance;
                }

            return rate;
        }
        public override string ToString()
        {
            string PostalThird = "Postal Service (Third Class)";

            return PostalThird;
        }
    }
}
