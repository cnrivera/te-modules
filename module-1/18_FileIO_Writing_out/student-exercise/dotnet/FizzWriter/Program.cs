using System;
using System.IO;


namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string directory = Environment.CurrentDirectory; //C:\Users\Student\workspace\crivera-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet
            string filename = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, filename);

            using (StreamWriter sw = new StreamWriter(fullPath, false))
            {
                for (int i = 1; i < 301; i++)
                {
                    bool hasThrees = i.ToString().Contains("3");
                    bool hasFives = i.ToString().Contains("5");

                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        sw.WriteLine("FizzBuzz");
                    }
                    else if (hasThrees == true || i % 3 == 0)
                    {
                        sw.WriteLine("Fizz");
                    }
                    else if (hasFives == true || i % 5 == 0)
                    {
                        sw.WriteLine("Buzz");
                    }
                    else
                    {
                        sw.WriteLine(i);
                    }

                }
                Console.WriteLine("File complete. Check the debug bin.");
            }
        }


        




        







    }
}
