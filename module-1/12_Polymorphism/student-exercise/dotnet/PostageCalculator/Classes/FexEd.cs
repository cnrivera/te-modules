using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class FexEd : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight) //weight is in ounces
        {
            double rate = 20.00;
     
            //correct the method when I figure out what to do with miles and ounces
            if (distance > 500) 
                {
                rate += 5.00;
                }


            if (weight > 48)
                {
                rate += 3.00;
                }
          
            return rate;


        }

        public override string ToString()
        {
            string FexEd = "FexEd";

            return FexEd;
        }
    }
}
