using System;

namespace Code_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //Method to convert to binary
        private static string ConvertNumberToBinary(int base10)
        {
            string binary = "";
            while (base10 > 0)
            {
                binary = (base10 % 2) + binary;
                base10 = base10 / 2;
            }

            return binary;
        }

        //Method to print array to console
        private static void WriteArrayToConsole(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ",");
                }
            }
        }
}
