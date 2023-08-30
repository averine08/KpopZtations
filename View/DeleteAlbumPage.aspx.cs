using KpopZtation.Handler;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class DeleteAlbumPage : System.Web.UI.Page
    {
        public int artistID;
        public int albumID;
        public Album album;
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

            if (Request.QueryString["AlbumID"] == null || Request.QueryString["ArtistID"] == null)
            {
                Response.Redirect("/Home");
            }

            artistID = int.Parse(Request.QueryString["ArtistID"]);
            albumID = int.Parse(Request.QueryString["AlbumID"]);
            album = AlbumRepository.getAlbumByID(albumID);

            if (album == null)
            {
                Response.Redirect("/NotFound");
            }

            AlbumName.Text = album.AlbumName;
            AlbumDesc.Text = album.AlbumDescription;
            AlbumPrice.Text = album.AlbumPrice.ToString();
            AlbumStock.Text = album.AlbumStock.ToString();

            ImgAlbum.ImageUrl = "~/Assets/Albums/" + album.AlbumImage;

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            // untuk delete file image di folder Assets, bukan delete di database
            string imageAlbum = AlbumRepository.getAlbumByID(albumID).AlbumImage;
            string filePath = Server.MapPath("~/Assets/Albums/" + imageAlbum);
            AlbumHandler.deleteImageFile(filePath);

            AlbumHandler.deleteAlbumByID(albumID);
            Response.Redirect(ResolveUrl("/ArtistDetails") + "?ArtistID=" + artistID);
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ResolveUrl("/ArtistDetails") + "?ArtistID=" + artistID);
        }
    }
}