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
    public partial class InsertAlbumPage : System.Web.UI.Page
    {
        public static int ArtistID;
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
            if (Request.QueryString["ArtistID"] == null)
            {
                Response.Redirect("/ArtistDetails");
            }
            ArtistID = int.Parse(Request.QueryString["ArtistID"]);
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            string albumName = TxtAlbumName.Text;
            string albumDesc = TxtAlbumDesc.Text;
            string albumPrice = TxtPrice.Text;
            string albumStock = TxtStock.Text;
            HttpPostedFile albumImage = AlbumImageFileUpload.PostedFile;
            int artistID = int.Parse(Request.QueryString["ArtistID"]);
            string errorMsg = AlbumController.insertAlbum(artistID, albumName, albumDesc, albumPrice, albumStock, albumImage);
            if (errorMsg.Equals("Insert Successful"))
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