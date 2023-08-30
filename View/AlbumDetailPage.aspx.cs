using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class AlbumDetailPage : System.Web.UI.Page
    {
        public Album albumObject = null;
        public Customer cust = null;
        public int albumID;
        public static int artistID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["AlbumID"] == null)
            {
                Response.Redirect("/Home");
            }



            albumID = int.Parse(Request.QueryString["AlbumID"]);
            artistID = AlbumRepository.getArtistIDByAlbumID(albumID).ArtistID;
            Debug.WriteLine(artistID);
            albumObject = AlbumRepository.getAlbumByID(albumID);

            if (albumObject == null)
            {
                Response.Redirect("/NotFound");
            }

            string albumImage = albumObject.AlbumImage;
            Image1.ImageUrl = "~/Assets/Albums/" + albumImage;

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {

            }
            else
            {
                if (Session["user"] == null)
                {
                    var id = int.Parse(Request.Cookies["user_cookie"].Value);
                    cust = CustomerRepository.GetCustomerById(id);
                    Session["user"] = cust;
                }
                else
                {
                    cust = (Customer)Session["user"];
                }
            }
            // untuk testing
            //cust = (from i in db.Customers where i.CustomerRole.Equals("CST") select i).FirstOrDefault();
        }

        protected void BtnAddToCart_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            LblError.Text = "";
            int customerID = cust.CustomerID;

            string quantity = TxtQuantity.Text;
            string errorMsg = CartController.insertItem(customerID, albumID, quantity);

            if (errorMsg.Equals("Album added to cart"))
            {
                LblError.Text = errorMsg;
                LblError.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LblError.Text = errorMsg;
            }
        }
    }
}