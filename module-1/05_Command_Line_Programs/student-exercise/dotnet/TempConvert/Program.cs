﻿using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            string strGetTemp = Console.ReadLine();
            int intTemp = int.Parse(strGetTemp);

            Console.Write("Is the temperature in (C)elsius or (F)ahrenheit? ");
            string strTempScale = Console.ReadLine();
            string strTempScaleUpper = strTempScale.ToUpper();

            double tempCelsiusConvert = (intTemp - 32) / 1.8;
            double tempFahrenheitConvert = intTemp * 1.8 + 32;

            if (strTempScaleUpper == "F")
            {
                Console.WriteLine(intTemp + "F is " + Math.Floor(tempCelsiusConvert) + "C.");
            }
            else if (strTempScaleUpper == "C")
            {
                Console.WriteLine(intTemp + "C is " + Math.Floor(tempFahrenheitConvert) + "F.");
            }
           
        }

        
    }
}
