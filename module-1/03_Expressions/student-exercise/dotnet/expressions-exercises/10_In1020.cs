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
         Given 2 int values, return true if either of them is in the range 10..20 inclusive.
         In1020(12, 99) → true
         In1020(21, 12) → true
         In1020(8, 99) → false
         */
        public bool In1020(int a, int b)
        {
            bool retValue = false;

            bool valueA = (a >= 10) && (a <= 20);
            bool valueB = (b >= 10) && (b <= 20);

            if (valueA || valueB)
            {
                retValue = true;
            }
            return retValue;
        }

    }
}
