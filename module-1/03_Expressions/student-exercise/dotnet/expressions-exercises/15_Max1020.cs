using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            int largerValue = 0;

            bool inARange = (a >= 10) && (a <= 20);
            bool inBRange = (b >= 10) && (b <= 20);

            if(inARange && !inBRange)
            {
                largerValue = a;
            }
            else if(inBRange && !inARange)
            {
                largerValue = b;
            }
            else if (inARange && inBRange)
            {
                if (a > b)
                {
                    largerValue = a;
                }
                if (b > a)
                {
                    largerValue = b;
                }
                if (a == b)
                {
                    largerValue = a;
                }
            }
          
            return largerValue;
        }

    }
}
