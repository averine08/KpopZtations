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
    public partial class ArtistDetailPage : System.Web.UI.Page
    {
        public Artist artistObject = null;
        public List<Album> albumList = null;
        public Customer cust = null;
        public int ArtistID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //KpopZtationDBEntities db = new KpopZtationDBEntities();

            //List<Artist> artistList = (from i in db.Artists select i).ToList();

            //artistTable.DataSource = artistList;
            //artistTable.DataBind();
            //GVAlbums.DataSource = albumList;
            //GVAlbums.DataBind();

            if (Request.QueryString["ArtistID"] == null)
            {
                Response.Redirect("/Home");
            }
            ArtistID = Convert.ToInt32(Request.QueryString["ArtistID"]);

            Debug.Write(ArtistID);
            artistObject = ArtistRepository.getArtistByID(ArtistID);
            if(artistObject == null)
            {
                Response.Redirect("/NotFound");
            }
            string ArtistImage = artistObject.ArtistImage;
            Image1.ImageUrl = "~/Assets/Artists/"+ ArtistImage;

            albumList = AlbumRepository.getAlbumByArtistID(ArtistID);



            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {

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
            }
            // untuk testing
            //cust = (from i in db.Customers where i.CustomerRole.Equals("ADM") select i).FirstOrDefault();
        }

        public void GetImageUrl(Album item)
        {
            Image2.ImageUrl = "~/Assets/Albums/" + item.AlbumImage;
            Console.WriteLine(item.AlbumImage);
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect(ResolveUrl("/InsertAlbum") + "?ArtistID=" + ArtistID);
        }
    }
}