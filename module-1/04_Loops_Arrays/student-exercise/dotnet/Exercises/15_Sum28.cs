﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
         Sum28([2, 3, 2, 2, 4, 2]) → true
         Sum28([2, 3, 2, 2, 4, 2, 2]) → false
         Sum28([1, 2, 3, 4]) → false
         */
        public bool Sum28(int[] nums)
        {
            bool eightSum = false;
            int twosEqualEight = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    twosEqualEight += 1;
                }
            }
            if (twosEqualEight == 4)
            {
                eightSum = true;
            }

            return eightSum;
        }

    }
}
