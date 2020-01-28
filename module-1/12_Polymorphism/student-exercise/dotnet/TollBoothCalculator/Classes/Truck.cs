using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;
            double ratePerMile;

            if (NumberOfAxles == 4)
            {
                ratePerMile = 0.040;
                toll = ratePerMile * distance;
            }

            else if (NumberOfAxles == 6)
            {
                ratePerMile = 0.045;
                toll = ratePerMile * distance;
            }

            else if (NumberOfAxles >= 8)
            {
                ratePerMile = 0.048;
                toll = ratePerMile * distance;
            }

            return toll;


        }
        public override string ToString()
        {
            string truck = "Truck";

            if (NumberOfAxles == 4)
            {
                truck = "Truck (4 axles)";
            }

            if (NumberOfAxles == 6)
            {
                truck = "Truck (6 axles)";
            }

            if (NumberOfAxles >= 8)
            {
                truck = "Truck (8 axles)";
            }

            return truck;
        }





    }
}
