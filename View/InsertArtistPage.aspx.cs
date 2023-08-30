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
    public partial class InsertArtistPage : System.Web.UI.Page
    {
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
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            LblError.ForeColor = System.Drawing.Color.Red;
            string artistName = TxtArtistName.Text;
            HttpPostedFile artistImage = ArtistImageFileUpload.PostedFile;
            int errorNum = ArtistController.insertArtist(artistName, artistImage);
            if (errorNum == 6)
            {
                LblError.Text = "Input Successful";
                artistImage.SaveAs(Server.MapPath("~/Assets/Artists/" + artistImage.FileName));
                LblError.ForeColor = System.Drawing.Color.Green;
            }
            else if (errorNum == 5)
            {
                LblError.Text = "Artist Name must be unique";
            }
            else if (errorNum == 4)
            {
                LblError.Text = "file size must be lower than 2MB";
            }
            else if (errorNum == 3)
            {
                LblError.Text = "file extension must be .png, .jpg, .jpeg, or .jfif";
            }
            else if (errorNum == 2)
            {
                LblError.Text = "Artist image file must not be empty";
            }
            else if (errorNum == 1)
            {
                LblError.Text = "Artist name must not be empty";
            }

        }
    }
}