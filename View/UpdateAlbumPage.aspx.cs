using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateAlbumPage : System.Web.UI.Page
    {
        int albumID;
        public static int artistID;
        public Customer cust = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("/Home");
            }
            else
            {
                if (Session["user"] == null)
                {
                    var id = Int32.Parse(Request.Cookies["user_cookie"].Value);
                    cust = CustomerRepository.GetCustomerById(id);
                    Session["user"] = cust;
                }
                else
                {
                    cust = (Customer)Session["user"];
                }

                if (!cust.CustomerRole.Equals("ADM"))
                {
                    Response.Redirect("/Home");
                }
            }

            LblError.Text = "";
            if (Request.QueryString["AlbumID"] == null)
            {
                Response.Redirect("/ArtistDetails");
            }
            albumID = int.Parse(Request.QueryString["AlbumID"]);
            artistID = AlbumRepository.getArtistIDByAlbumID(albumID).ArtistID;
            Album albumBefore = AlbumRepository.getAlbumByID(albumID);
            if(albumBefore == null)
            {
                Response.Redirect("/NotFound");
            }
            TxtAlbumNameBefore.Text = albumBefore.AlbumName;
            TxtAlbumDescBefore.Text = albumBefore.AlbumDescription;
            TxtPriceBefore.Text = albumBefore.AlbumPrice.ToString();
            TxtStockBefore.Text = albumBefore.AlbumStock.ToString();

            string imageUrl = albumBefore.AlbumImage;
            ImageBefore.ImageUrl = "~/Assets/Albums/" + imageUrl;
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            string albumName = TxtAlbumNameAfter.Text;
            string albumDesc = TxtDescAfter.Text;
            string albumPrice = TxtPriceAfter.Text;
            string albumStock = TxtStockAfter.Text;
            HttpPostedFile albumImage = AlbumImageFileUpload.PostedFile;
            albumID = int.Parse(Request.QueryString["AlbumID"]);
            string errorMsg = AlbumController.updateAlbum(albumID, albumName, albumDesc, albumPrice, albumStock, albumImage);
            if (errorMsg.Equals("Update Successful"))
            {
                LblError.Text = errorMsg;
                albumImage.SaveAs(Server.MapPath("~/Assets/Albums/" + albumImage.FileName));
                LblError.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LblError.Text = errorMsg;
            }
        }
    }
}