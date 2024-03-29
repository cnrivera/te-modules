﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            string directory = Environment.CurrentDirectory; // C:\Users\Student\workspace\crivera-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet
            string filename = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, filename);

            
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                // Prints the current datetime
                sw.WriteLine(DateTime.UtcNow);

                // Prints Hello World!
                sw.Write("Hello ");
                sw.Write("World!");

                // Prints blank line
                sw.WriteLine();

                // Prints
                // Tech
                // Elevator
                sw.WriteLine("Tech");
                sw.WriteLine("Elevator");
            }
            
            // After the using statement ends, file has now been written
            // and closed for further writing
        }


        
    }
}
