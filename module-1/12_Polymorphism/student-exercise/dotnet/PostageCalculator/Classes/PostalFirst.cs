using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalFirst : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0; 

                //ounces
                if (weight <= 2)
                {
                    rate = 0.035 * distance;
                }
                else if (weight <= 8)
                {
                    rate = 0.040 * distance;
                }
                else if (weight <= 15)
                {
                    rate = 0.047 * distance;
                } 
            
                //pounds{
                else if (weight <= 3*16)
                {
                    rate = 0.195 * distance;
                }
                else if (weight <= 8*16)
                {
                    rate = 0.450 * distance;
                }
                else if (weight > 8*16)
                {
                    rate = 0.500 * distance;
                }
             
            return rate;

        }
        public override string ToString()
        {
            string PostalFirst = "Postal Service (First Class)";

            return PostalFirst;
        }
    }

}
