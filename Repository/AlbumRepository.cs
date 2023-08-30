using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {
        private static KpopZtationDBEntities db = DatabaseSingleton.GetInstance();
        public static List<Album> getAlbumByArtistID(int id)
        {
            return (from x in db.Albums where x.ArtistID == id select x).ToList();
        }

        public static string insertAlbum(int artistID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            Album album = AlbumFactory.newAlbum(artistID, albumName, albumDesc, albumPrice, albumStock, albumImage);
            db.Albums.Add(album);
            db.SaveChanges();

            return "Insert Successful";
        }

        public static string updateAlbum(int albumID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            Album album = getAlbumByID(albumID);
            album.AlbumName = albumName;
            album.AlbumDescription = albumDesc;
            album.AlbumImage = albumImage.FileName;
            album.AlbumPrice = int.Parse(albumPrice);
            album.AlbumStock = int.Parse(albumStock);

            db.SaveChanges();

            return "Update Successful";
        }
        public static Album getAlbumByID(int id)
        {
            return (from x in db.Albums where x.AlbumID == id select x).FirstOrDefault();
        }

        public static Album getArtistIDByAlbumID(int albumID)
        {
            Album artistO = (from i in db.Albums where i.AlbumID.Equals(albumID) select i).FirstOrDefault();
            return artistO;
        }
        public static void deleteAlbumByID(int id)
        {
            Album deletedAlbum = getAlbumByID(id);
            db.Albums.Remove(deletedAlbum);
            db.SaveChanges();
        }
        public static void substractStockFromAlbum(int albumID, int qty)
        {
            Album selectedAlbum = getAlbumByID(albumID);
            selectedAlbum.AlbumStock -= qty;

            db.SaveChanges();
        }
    }
}