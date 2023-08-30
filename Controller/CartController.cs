using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CartController
    {
        public static string insertItem(int customerID, int albumId, string quantity)
        {
            if (quantity.Trim().Equals(""))
            {
                return "Quantity must be filled";
            }
            else if (!quantity.Any(Char.IsDigit))
            {
                return "Quantity must be numeric";
            }
            else if (Convert.ToInt32(quantity) <= 0)
            {
                return "Quantity must be a positive number";
            }
            else
            {
                return CartHandler.InsertItem(customerID, albumId, quantity);
            }
        }
    }
}