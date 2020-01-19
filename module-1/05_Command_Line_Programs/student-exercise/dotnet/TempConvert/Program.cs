using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature:");
            string strGetTemp = Console.ReadLine();
            int intTemp = int.Parse(strGetTemp);

            Console.WriteLine("Is the temperature in (C)elsius or (F)ahrenheit?");
            string strTempScale = Console.ReadLine();

            double tempCelsiusConvert = (intTemp - 32) / 1.8;
            double tempFahrenheitConvert = intTemp * 1.8 + 32;

            if (strTempScale == "F")
            {
                Console.WriteLine(intTemp + "F is " + Math.Floor(tempCelsiusConvert) + "C.");
            }
            else if (strTempScale == "C")
            {
                Console.WriteLine(intTemp + "C is " + Math.Floor(tempFahrenheitConvert) + "F.");
            }
           
        }

        
    }
}
