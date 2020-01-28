using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;

            toll = distance * 0.020;

            if (HasTrailer)
            {
                toll = toll + 1.00;
            }

            return toll;

        }


        public override string ToString()
        {
            string car = "Car";

            if (HasTrailer)
            {
                car = "Car (with trailer)";
            }
            return car;
        }   
        
    }

    
}
