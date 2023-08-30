using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class ArtistHandler
    {
        public static int InsertArtist(string artistName, HttpPostedFile artistImage)
        {
            Artist artist = ArtistRepository.getArtistByName(artistName);

            if (artist != null)
            {
                return 5;
            }
            else
            {
                ArtistRepository.insertArtist(artistName, artistImage);
                return 6;
            }
        }

        public static int UpdateArtist(int id, string artistName, HttpPostedFile artistImage)
        {
            Artist artist = ArtistRepository.getArtistByName(artistName);

            if (artist != null)
            {
                return 5;
            }
            else
            {
                ArtistRepository.updateArtist(id, artistName, artistImage.FileName);
                return 6;
            }
        }

        public static int DeleteArtist(int id, string artistName, string filePath)
        {
            if (ArtistRepository.getArtistByID(id) == null)
            {
                return 1;
            }
            else if (ArtistRepository.getArtistByName(artistName) == null)
            {
                return 2;
            }
            else if (ArtistRepository.getArtistByIDandName(id, artistName) == null)
            {
                return 3;
            }
            else
            {
                deleteImageFile(filePath);
                ArtistRepository.deleteArtist(id, artistName);
                TransactionHandler.CheckEmptyTransactions();
                return 4;
            }
        }

        public static void deleteImageFile(string filePath)
        {
            try
            {
                File.Delete(filePath);
            }
            catch (IOException a)
            {
                Console.WriteLine("Error deleting : " + a.Message);
            }
        }
    }
}