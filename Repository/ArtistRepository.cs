using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class ArtistRepository
    {
        public static KpopZtationDBEntities db = DatabaseSingleton.GetInstance();

        public static void insertArtist(string artistName, HttpPostedFile artistImage)
        {
            Artist artist = ArtistFactory.newArtist(artistName, artistImage);
            db.Artists.Add(artist);
            db.SaveChanges();
        }
        public static List<Artist> getAllArtist()
        {
            return (from i in db.Artists select i).ToList();
        }

        public static Artist getArtistByID(int ID)
        {
            Artist artist = (from i in db.Artists where i.ArtistID.Equals(ID) select i).FirstOrDefault();
            return artist;
        }

        public static Artist getArtistByName(string artistName)
        {
            Artist artist = (from i in db.Artists where i.ArtistName.Equals(artistName) select i).FirstOrDefault();
            return artist;
        }
        public static Artist getArtistByIDandName(int ID, string artistName)
        {
            Artist artist = (from i in db.Artists where i.ArtistID.Equals(ID) && i.ArtistName.Equals(artistName) select i).FirstOrDefault();
            return artist;
        }

        public static void deleteArtist(int ID, string artistName)
        {
            Artist artist = (from i in db.Artists where i.ArtistID.Equals(ID) && i.ArtistName.Equals(artistName) select i).FirstOrDefault();
            db.Artists.Remove(artist);
            db.SaveChanges();
        }
        public static void updateArtist(int id, string artistName, string artistImage)
        {
            Artist artist = getArtistByID(id);
            artist.ArtistName = artistName;
            artist.ArtistImage = artistImage;

            db.SaveChanges();

        }
    }
}