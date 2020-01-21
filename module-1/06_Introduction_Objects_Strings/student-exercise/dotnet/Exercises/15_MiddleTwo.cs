﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of even length, return a string made of the middle two chars, so the string "string"
         yields "ri". The string length will be at least 2.
         MiddleTwo("string") → "ri"
         MiddleTwo("code") → "od"
         MiddleTwo("Practice") → "ct"
         */
        public string MiddleTwo(string str)
        {
            string stringDeadCenter = "";

            if (str.Length == 2)
            {
                stringDeadCenter = str;
            }
            if (str.Length > 2)
            {
                stringDeadCenter = str.Substring((str.Length / 2) - 1, 2 );
            }
            
            return stringDeadCenter;
        }
    }
}
