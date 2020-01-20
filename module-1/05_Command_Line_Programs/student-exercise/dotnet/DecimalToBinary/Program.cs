using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter a series of decimal values (separated by spaces): "); //request information from user
            string strDecValues = Console.ReadLine(); //store input int a string
            string[] decValuesArr = strDecValues.Split(" "); //split string into an array using space char
            int[] decToBinary = Array.ConvertAll(decValuesArr,int.Parse);

            for (int i = 0; i < decValuesArr.Length; i++)
            {
                Console.WriteLine(decToBinary[i] + "in binary is " + ConvertNumberToBinary(decToBinary[i]));

            }

            
        }
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
    }
}
