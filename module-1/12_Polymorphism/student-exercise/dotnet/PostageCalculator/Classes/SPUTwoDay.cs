using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUTwoDay : IDeliveryDriver
    {
    
        public double CalculateRate(int distance, double weight)
        {
           
            return (weight * 0.050) /16 * distance;

        }

        public override string ToString()
        {
            string SPUTwoDay = "SPU (Two Day)";

            return SPUTwoDay;
        }
    }
}
