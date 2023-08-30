using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class AlbumHandler
    {
        public static string insertAlbum(int artistID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            return AlbumRepository.insertAlbum(artistID, albumName, albumDesc, albumPrice, albumStock, albumImage);
        }
        public static string updateAlbum(int albumID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            return AlbumRepository.updateAlbum(albumID, albumName, albumDesc, albumPrice, albumStock, albumImage);
        }

        public static void deleteAlbumByID(int albumID)
        {
            AlbumRepository.deleteAlbumByID(albumID);
            TransactionHandler.CheckEmptyTransactions();
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