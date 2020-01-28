using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        public double CalculateToll(int distance)
        {
            return 0 * distance;

        }

        public override string ToString()
        {
            string tank = "Tank";
            return tank;

        }

    }
}
