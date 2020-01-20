using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: "); //make request of user
            int fibRequest = int.Parse(Console.ReadLine()); //input user response and parse as an integer

            if (fibRequest == 0 || fibRequest == 1)
            {
                Console.Write(0);
            }
            else
            {
                Console.Write("0, 1, 1, "); 
            }
            int fib1 = 1;
            int fib2;

            for (int i = 1; i + fib1 <= fibRequest;)
            {
                fib2 = i + fib1;
                i = fib1;
                fib1 = fib2;
                Console.Write(fib2 + ", ");
            }

            

           

        }
    }
}
