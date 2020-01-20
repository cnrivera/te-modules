using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: "); //make request of user
            int fibRequest = int.Parse(Console.ReadLine()); //input user response and parse as an integer
           
            Console.Write(0 + ", " + 1 + ", "); //account for first two numbers in sequence

            //CODE BELOW DOES NOT YIELD RESULT. CREATES FIBONACCI SEQUENCE OF FIBREQUEST LENGTH, NOT UP TO FIBREQUEST TOTAL.
            //STILL WORKING ON CORRECT RESULT.

            int[] fibSequence = new int[fibRequest];
            fibSequence[0] = 0;
            fibSequence[1] = 1;

                for (int i = 2; i < fibRequest; i++)
                {
                  fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
               
                  Console.Write(fibSequence[i] + ", ");
                }

    }
    }
}
