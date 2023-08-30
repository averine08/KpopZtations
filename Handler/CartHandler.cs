using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CartHandler
    {
        public static string InsertItem(int customerID, int albumId, string quantity)
        {
            Cart userCart = CartRepository.getCartByID(albumId, customerID);
            Album selectedAlbum = AlbumRepository.getAlbumByID(albumId);

            if (userCart == null)
            {
                if (int.Parse(quantity) > selectedAlbum.AlbumStock)
                {
                    return "Selected album quantity must not be more than album stock";
                }
                else
                {
                    return CartRepository.insertItem(customerID, albumId, int.Parse(quantity));
                }
            }
            else if (int.Parse(quantity) + userCart.Qty > selectedAlbum.AlbumStock)
            {
                return "Selected album quantity and album quantity already in cart must not be more than album stock";
            }
            else
            {
                return CartRepository.insertItem(customerID, albumId, int.Parse(quantity));
            }
        }

        public static void DeleteItemFromCart(int customerID, int albumID)
        {
            CartRepository.deleteCartByID(customerID, albumID);
        }

        public static void CheckOut(List<Cart> listCart, int customerID)
        {
            DateTime date = DateTime.Now;
            int transactionID = TransactionRepository.insertTransactionHeader(date, customerID);

            foreach (var item in listCart)
            {
                TransactionRepository.insertTransactionDetail(transactionID, item.AlbumID, item.Qty);
                AlbumRepository.substractStockFromAlbum(item.AlbumID, item.Qty);
            }

            foreach (var item in listCart)
            {
                CartRepository.deleteCartByCustomerID(customerID);
            }
        }
    }
}