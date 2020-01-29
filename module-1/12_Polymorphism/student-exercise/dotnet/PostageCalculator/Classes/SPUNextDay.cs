using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUNextDay : IDeliveryDriver
    {


        public double CalculateRate(int distance, double weight)
        {
           
            return (weight * 0.075) /16 * distance;


        }

        public override string ToString()
        {
            string SPUNextDay = "SPU (Next Day)";

            return SPUNextDay;



        }
    }
}
