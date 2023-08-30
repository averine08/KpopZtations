using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CartRepository
    {
        private static KpopZtationDBEntities db = DatabaseSingleton.GetInstance();
        public static Cart getCartByID(int albumID, int customerID)
        {
            return (from i in db.Carts where i.AlbumID == albumID && i.CustomerID == customerID select i).FirstOrDefault();
        }

        public static Cart getCartByCustomerID(int customerID)
        {
            return (from i in db.Carts where i.CustomerID == customerID select i).FirstOrDefault();
        }

        public static string insertItem(int customerID, int albumID, int quantity)
        {
            Cart newCart = CartFactory.createCart(customerID, albumID, quantity);
            db.Carts.Add(newCart);
            db.SaveChanges();

            return "Album added to cart";
        }

        public static List<Cart> getCartListByID(int customerID)
        {
            List<Cart> cartList = new List<Cart>();
            cartList = (from i in db.Carts where i.CustomerID == customerID select i).ToList();

            return cartList;
        }
        public static void deleteCartByID(int customerID, int albumID)
        {
            Cart deletedCart = getCartByID(albumID, customerID);
            db.Carts.Remove(deletedCart);
            db.SaveChanges();
        }

        public static void deleteCartByCustomerID(int customerID)
        {
            Cart deletedCart = getCartByCustomerID(customerID);
            db.Carts.Remove(deletedCart);
            db.SaveChanges();
        }
    }
}