using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            string strGetMeasure = Console.ReadLine();
            int MeasureInt = int.Parse(strGetMeasure);

            Console.Write("Is the measurement in (m)eters or (f)eet? ");
            string strGetMeasureUnit = Console.ReadLine();
            string strGetMeasureUnitLower = strGetMeasureUnit.ToLower();

            double feetToMeters = MeasureInt * 0.3048;
            double metersToFeet = MeasureInt * 3.2808399;
            
            if (strGetMeasureUnitLower == "f")
            {
                Console.WriteLine(strGetMeasure + "f is " + Math.Floor(feetToMeters) +"m.");
            }
            else if (strGetMeasureUnitLower == "m")
            {
                Console.WriteLine(strGetMeasure + "m is " + Math.Floor(metersToFeet) + "f.");
            }
        }
    }
}
