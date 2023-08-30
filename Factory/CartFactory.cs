using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int customerID, int albumID, int quantity)
        {
            Cart newCart = new Cart();
            newCart.AlbumID = albumID;
            newCart.CustomerID = customerID;
            newCart.Qty = quantity;

            return newCart;
        }
    }
}