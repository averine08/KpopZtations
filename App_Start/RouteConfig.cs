using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace KpopZtation.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute("", "Home", "~/View/HomePage.aspx");
            routes.MapPageRoute("", "Register", "~/View/RegisterPage.aspx");
            routes.MapPageRoute("", "", "~/View/LoginPage.aspx");
            routes.MapPageRoute("", "Login", "~/View/LoginPage.aspx");
            routes.MapPageRoute("", "UpdateArtist", "~/View/UpdateArtistPage.aspx");
            routes.MapPageRoute("", "ArtistDetails", "~/View/ArtistDetailPage.aspx");
            routes.MapPageRoute("", "InsertArtist", "~/View/InsertArtistPage.aspx");
            routes.MapPageRoute("", "DeleteArtist", "~/View/DeleteArtistPage.aspx");
            routes.MapPageRoute("", "UpdateAlbum", "~/View/UpdateAlbumPage.aspx");
            routes.MapPageRoute("", "DeleteAlbum", "~/View/DeleteAlbumPage.aspx");
            routes.MapPageRoute("", "AlbumDetails", "~/View/AlbumDetailPage.aspx");
            routes.MapPageRoute("", "InsertAlbum", "~/View/InsertAlbumPage.aspx");
            routes.MapPageRoute("", "Cart", "~/View/CartPage.aspx");
            routes.MapPageRoute("", "TransactionHistory", "~/View/TransactionHistoryPage.aspx");
            routes.MapPageRoute("", "TransactionReport", "~/View/TransactionReportPage.aspx");
            routes.MapPageRoute("", "TransactionDetails", "~/View/TransactionDetailsPage.aspx");
            routes.MapPageRoute("", "ViewProfile", "~/View/ViewProfilePage.aspx");
            routes.MapPageRoute("", "UpdateProfile", "~/View/UpdateProfilePage.aspx");
            routes.MapPageRoute("", "DeleteAccount", "~/View/DeleteAccountPage.aspx");

            routes.MapPageRoute("", "{*url}", "~/View/NotFound404.aspx");
        }
    }
}