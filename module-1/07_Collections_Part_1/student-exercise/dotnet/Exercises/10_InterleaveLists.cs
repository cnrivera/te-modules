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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {

            // alternate one list into the other
            //for loop to check indexes of one list, then the other, and add them to a new list?
            //iterate to next index?
            // if lists unequal length, last letters of longest list continue in order
            //comparison??
            // return new list

            List<int> interwovenList = new List<int>();

            int i;
            for (i = 0; i < listOne.Count && i < listTwo.Count; i++)
            {
                interwovenList.Add(listOne[i]);
                interwovenList.Add(listTwo[i]);
            }

            while (i < listOne.Count)
            {
                interwovenList.Add(listOne[i]);
                i++;
                   
            }

            while (i < listTwo.Count)
            {
                interwovenList.Add(listTwo[i]);
                i++;
            }
            


            return interwovenList;


        }
    }
}
