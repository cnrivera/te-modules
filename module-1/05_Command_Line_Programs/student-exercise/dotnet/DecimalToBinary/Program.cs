using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter a series of decimal values (separated by spaces): ");
            string strDecValues = Console.ReadLine();
            string[] decValuesArr = strDecValues.Split(" ");

            for (int i = 0; i < decValuesArr.Length; i++)
            {
                string ConvertNumberToBinary(int base10)
                {
                    string binary = "";
                    while (base10 > 0)
                    {
                        binary = (base10 % 2) + binary; base10 = base10 / 2;
                    }
                    return binary;

                    //int decToBinary = int.Parse(decValuesArr[i]);
                    //Console.WriteLine( + "in binary is " + );
                }
            }
        }
    }
}
