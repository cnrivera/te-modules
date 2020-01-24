using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; }
        public string SubmitterName { get; }
        public string LetterGrade
        {
            get
            {
                double endMarks = EarnedMarks * 1.0 / PossibleMarks;
                if (endMarks >= .9)
                {
                    return "A";
                }
                else if (endMarks <= .89 && endMarks >= .8)
                {
                    return "B";
                }
                else if (endMarks <= .79 && endMarks >=.7)
                {
                    return "C";
                }
                else if (endMarks <=.69 && endMarks >= .6)
                    {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
       
             
        }
            
 

    }
}
