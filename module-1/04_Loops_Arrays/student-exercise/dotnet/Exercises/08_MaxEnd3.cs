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
         Given an array of ints length 3, figure out which is larger between the first and last elements
         in the array, and set all the other elements to be that value. Return the changed array.
         MaxEnd3([1, 2, 3]) → [3, 3, 3]
         MaxEnd3([11, 5, 9]) → [11, 11, 11]
         MaxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            bool firstLarger = (nums[0] > nums[nums.Length - 1]);
            bool lastLarger = (nums[nums.Length - 1] > nums[0]);
            int higherRepeat = 0;

            if (firstLarger)
            {
                higherRepeat = nums[0];
            }

            else if (lastLarger)
            {
                higherRepeat = (nums[nums.Length - 1]);
            }
            return new int[3] {higherRepeat, higherRepeat, higherRepeat};
        }

    }
}
