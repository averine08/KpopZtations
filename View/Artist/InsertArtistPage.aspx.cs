using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Artist
{
    public partial class InsertArtistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsertArtist_Click(object sender, EventArgs e)
        {
            string ArtistName = TxtArtistName.Text;
            string ArtistImageUrl = "~/Assets/" + ImgArtist.FileName;
            ImgArtist.SaveAs(Server.MapPath(ArtistImageUrl));

            ArtistImageUrl = ArtistImageUrl.Substring(1);

            lblView.Text = ArtistImageUrl;

        }
    }
}