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
         Given an array of ints length 3, return the sum of all the elements.
         Sum3([1, 2, 3]) → 6
         Sum3([5, 11, 2]) → 18
         Sum3([7, 0, 0]) → 7
         */
        public int Sum3(int[] nums)
        {
            int intSum = (nums[0] + nums[1] + nums[2]);
            
            return intSum;
        }

    }
}
