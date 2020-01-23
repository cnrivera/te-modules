using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {

        public int TotalNumberOfItems { get; private set; }
        public decimal TotalAmountOwed { get; private set; }


        public ShoppingCart()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0;
        }

        public decimal GetAveragePricePerItem()
        {
            decimal total = 0;
            if (TotalAmountOwed > 0 && TotalNumberOfItems > 0)
            {
                total = TotalAmountOwed / TotalNumberOfItems;
            }
            
            return total;
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems += numberOfItems;
            TotalAmountOwed = pricePerItem * numberOfItems;
        }

        public void Empty()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0;
        }
       
    }
}
