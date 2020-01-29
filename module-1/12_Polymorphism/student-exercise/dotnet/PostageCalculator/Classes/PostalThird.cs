using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalThird : PostalService, IPostage
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;

            if (IsOunces == true)
            {
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
            }

            if (IsPounds == true)
            {
                if (weight <= 3)
                {
                    rate = 0.0150 * distance;
                }
                else if (weight <= 8)
                {
                    rate = 0.0160 * distance;
                }
                else if (weight > 8)
                {
                    rate = 0.0170 * distance;
                }

            }
            return rate;
        }
    }
}
