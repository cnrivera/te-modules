using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    interface IPostage
    {
        double CalculateRate(int distance, double weight);
    }
}
