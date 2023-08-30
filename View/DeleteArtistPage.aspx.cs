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
    public partial class DeleteArtistPage : System.Web.UI.Page
    {
        public int id;
        public Artist artist;
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

            if (Request.QueryString["ArtistID"] == null)
            {
                Response.Redirect("/");
            }

            id = int.Parse(Request.QueryString["ArtistID"]);
            artist = ArtistRepository.getArtistByID(id);
            if (artist == null)
            {
                Response.Redirect("/NotFound");
            }

            TxtArtistName.Text = artist.ArtistName;
            ImgArtist.ImageUrl = "~/Assets/Artists/" + artist.ArtistImage;
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;

            // untuk delete file image di folder Assets, bukan delete di database
            string imageArtist = ArtistRepository.getArtistByID(id).ArtistImage;
            string filePath = Server.MapPath("~/Assets/Albums/" + imageArtist);
            int errorNum = ArtistController.deleteArtist(id.ToString(), artist.ArtistName, filePath);

            if (errorNum == 0)
            {
                LblError.Text = "Artist ID and Artist name cannot be empty";
            }
            else if (errorNum == 1)
            {
                LblError.Text = "There is no artist with id: " + id;
            }
            else if (errorNum == 2)
            {
                LblError.Text = "There is no artist with the name: " + artist.ArtistName;
            }
            else if (errorNum == 3)
            {
                LblError.Text = "There is no artist with id: " + id + " with the name: " + artist.ArtistName;
            }
            else if (errorNum == 4)
            {
                LblError.ForeColor = System.Drawing.Color.Green;
                LblError.Text = "Deletion Successful";
                Response.Redirect("/Home");
            }
        }
    }
}