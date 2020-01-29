using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUFourDay : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {
            
            return (weight * 0.0050) /16 * distance;
        }

        public override string ToString()
        {
            string SPUFourDay = "SPU (Four Day)";

            return SPUFourDay;
        }





    }
}
