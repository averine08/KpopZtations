using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class ArtistController
    {
        public static int deleteArtist(string artistID, string artistName, string filePath)
        {
            if (artistID.Equals("") || artistName.Equals(""))
            {
                return 0;
            }
            else
            {
                return ArtistHandler.DeleteArtist(int.Parse(artistID), artistName, filePath);
            }
        }
        public static int insertArtist(string artistName, HttpPostedFile artistImage)
        {
            if (artistName.Equals(""))
            {
                return 1;
            }
            else if (artistImage.FileName.Equals(""))
            {
                return 2;
            }
            else if (
                    !(artistImage.ContentType.Equals("image/png") ||
                    artistImage.ContentType.Equals("image/jpg") ||
                    artistImage.ContentType.Equals("image/jpeg") ||
                    artistImage.ContentType.Equals("image/jfif"))
                    )
            {
                return 3;
            }
            else if (artistImage.ContentLength >= 2000000)
            {
                return 4;
            }
            else
            {
                return ArtistHandler.InsertArtist(artistName, artistImage);
            }
        }
        public static int UpdateArtist(int id, string artistName, HttpPostedFile artistImage)
        {
            if (artistName.Equals(""))
            {
                return 1;
            }
            else if (artistImage.FileName.Equals(""))
            {
                return 2;
            }
            else if (
                    !(artistImage.ContentType.Equals("image/png") ||
                    artistImage.ContentType.Equals("image/jpg") ||
                    artistImage.ContentType.Equals("image/jpeg") ||
                    artistImage.ContentType.Equals("image/jfif"))
                    )
            {
                return 3;
            }
            else if (artistImage.ContentLength >= 2000000)
            {
                return 4;
            }
            else
            {
                return ArtistHandler.UpdateArtist(id, artistName, artistImage);
            }
        }
    }
}