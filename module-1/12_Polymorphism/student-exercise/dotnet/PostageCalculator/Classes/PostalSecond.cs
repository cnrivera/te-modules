using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalSecond : PostalService, IPostage
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;

            if (IsOunces == true)
            {
                if (weight <= 2)
                {
                    rate = 0.0035 * distance;
                }
                else if (weight <= 8)
                {
                    rate = 0.0040 * distance;
                }
                else if (weight <= 15)
                {
                    rate = 0.0047 * distance;
                }
            }

            if (IsPounds == true)
            {
                if (weight <= 3)
                {
                    rate = 0.0195 * distance;
                }
                else if (weight <= 8)
                {
                    rate = 0.0450 * distance;
                }
                else if (weight > 8)
                {
                    rate = 0.0500 * distance;
                }

            }
            return rate;
        }  
    }
}
