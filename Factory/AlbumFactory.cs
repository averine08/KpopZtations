using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class AlbumFactory
    {
        public static Album newAlbum(int artistID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            Album album = new Album();
            album.ArtistID = artistID;
            album.AlbumName = albumName;
            album.AlbumDescription = albumDesc;
            album.AlbumPrice = int.Parse(albumPrice);
            album.AlbumStock = int.Parse(albumStock);
            album.AlbumImage = albumImage.FileName;
            return album;
        }
    }
}