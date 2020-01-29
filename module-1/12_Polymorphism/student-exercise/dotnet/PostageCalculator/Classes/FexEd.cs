using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class FexEd
    {

        public bool IsOunces { get; }
        

        public FexEd()
        {
            //IsOunces = isOunces;
           
        }
        

        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.00;
     
            //correct the method when I figure out what to do with miles and ounces
            if (distance > 500 miles) 
                {
                rate += 5.00;
                }

            if (weight > 48 ounces)
                {
                rate += 3.00;
                }
            return rate;
        }

    }
}
