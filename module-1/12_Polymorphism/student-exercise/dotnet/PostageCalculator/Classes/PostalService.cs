using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalService // does the superclass also need the IPostage interface?
    {
        public bool IsOunces { get; }
        public bool IsPounds { get; }

        public PostalService()
        {
            //IsOunces = isOunces;
            //IsPounds = isPounds;
        }
    }

}

