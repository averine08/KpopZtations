using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class AlbumController
    {
        public static string insertAlbum(int artistID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            if (albumName.Trim().Equals(""))
            {
                return "Album name must be filled";
            }
            else if (albumName.Length > 50)
            {
                return "Album name must not be longer than 50 characters";
            }
            else if (albumDesc.Trim().Equals(""))
            {
                return "Album Desc must be filled";
            }
            else if (albumDesc.Length > 255)
            {
                return "Album description must not be longer than 255 characters";
            }
            else if (albumPrice.Trim().Equals(""))
            {
                return "Album price must be filled";
            }
            else if (!albumPrice.Any(Char.IsDigit))
            {
                return "Album price must be numeric";
            }
            else if (int.Parse(albumPrice) < 100000 || int.Parse(albumPrice) > 1000000)
            {
                return "Album price must be between 100000 and 1000000";
            }
            else if (albumStock.Trim().Equals(""))
            {
                return "Album stock must be filled";
            }
            else if (!albumStock.Any(Char.IsDigit))
            {
                return "Album stock must be numeric";
            }
            else if (int.Parse(albumStock) <= 0)
            {
                return "Album stock must have more than 0 stock";
            }
            else if (albumImage.Equals(""))
            {
                return "Album Image must not be empty";
            }
            else if (albumImage.FileName.Equals(""))
            {
                return "Album image file name must not be empty";
            }
            else if (
                    !(albumImage.ContentType.Equals("image/png") ||
                    albumImage.ContentType.Equals("image/jpg") ||
                    albumImage.ContentType.Equals("image/jpeg") ||
                    albumImage.ContentType.Equals("image/jfif"))
                    )
            {
                return "File extension must be .png, .jpg, .jpeg, or .jfif, ";
            }
            else if (albumImage.ContentLength >= 2000000)
            {
                return "File size must be lower than 2MB.";
            }
            else
            {
                return AlbumHandler.insertAlbum(artistID, albumName, albumDesc, albumPrice, albumStock, albumImage);
            }
        }
        public static string updateAlbum(int albumID, string albumName, string albumDesc, string albumPrice, string albumStock, HttpPostedFile albumImage)
        {
            if (albumName.Trim().Equals(""))
            {
                return "Album name must be filled";
            }
            else if (albumName.Length > 50)
            {
                return "Album name must not be longer than 50 characters";
            }
            else if (albumDesc.Trim().Equals(""))
            {
                return "Album Desc must be filled";
            }
            else if (albumDesc.Length > 255)
            {
                return "Album description must not be longer than 255 characters";
            }
            else if (albumPrice.Trim().Equals(""))
            {
                return "Album price must be filled";
            }
            else if (!albumPrice.Any(Char.IsDigit))
            {
                return "Album price must be numeric";
            }
            else if (int.Parse(albumPrice) < 100000 || int.Parse(albumPrice) > 1000000)
            {
                return "Album price must be between 100000 and 1000000";
            }
            else if (albumStock.Trim().Equals(""))
            {
                return "Album stock must be filled";
            }
            else if (!albumStock.Any(Char.IsDigit))
            {
                return "Album stock must be numeric";
            }
            else if (int.Parse(albumStock) <= 0)
            {
                return "Album stock must have more than 0 stock";
            }
            else if (albumImage.Equals(""))
            {
                return "Album Image must not be empty";
            }
            else if (albumImage.FileName.Equals(""))
            {
                return "Album image file name must not be empty";
            }
            else if (
                    !(albumImage.ContentType.Equals("image/png") ||
                    albumImage.ContentType.Equals("image/jpg") ||
                    albumImage.ContentType.Equals("image/jpeg") ||
                    albumImage.ContentType.Equals("image/jfif"))
                    )
            {
                return "File extension must be .png, .jpg, .jpeg, or .jfif, ";
            }
            else if (albumImage.ContentLength >= 2000000)
            {
                return "File size must be lower than 2MB.";
            }
            else
            {
                return AlbumHandler.updateAlbum(albumID, albumName, albumDesc, albumPrice, albumStock, albumImage);
            }
        }
    }
}