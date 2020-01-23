    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public Company()
        {

        }

        public string GetCompanySize()
        {
            string companySize = "";

            if (NumberOfEmployees < 50)
            {
                companySize = "small";
            }
            else if (NumberOfEmployees >= 50 && NumberOfEmployees <= 250)
            {
                companySize = "medium";
            }
            else if (NumberOfEmployees > 250)
            {
                companySize = "large";
            }
            return companySize;
        }

        public decimal GetProfit()
        {
            decimal profit = Revenue - Expenses;
            return profit;
        }
    }
}




