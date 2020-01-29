using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalSecond : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;

                //ounces            
                if (weight <= 2)
                {
                    rate = 0.0035 * distance;
                }
                else if (weight <= 8)
                {
                    rate = 0.0040 * distance;
                }
                if (weight <= 15)
                {
                    rate = 0.0047 * distance;
                }
            
                //pounds
                else if (weight <= 3*16)
                {
                    rate = 0.0195 * distance;
                }
                else if (weight <= 8*16)
                {
                    rate = 0.0450 * distance;
                }
                else if (weight > 8*16)
                {
                    rate = 0.0500 * distance;
                }

            return rate;
        }
        public override string ToString()
        {
            string PostalSecond = "Postal Service (Second Class)";

            return PostalSecond;
        }
    }
}
