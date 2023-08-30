<%@ Page Title="KpopZtation - Delete Album" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="DeleteAlbumPage.aspx.cs" Inherits="KpopZtation.View.DeleteAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #DescContent{
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" margin: 1rem 2rem;">
        <h1>Delete Album Page</h1>
        <b><asp:Label ID="LblAlbumName" runat="server" Text="Album Name: "></asp:Label></b>
        <asp:Label ID="AlbumName" runat="server" Text=""></asp:Label>
        <br />
        <b><asp:Label ID="LblAlbumImage" runat="server" Text="Album Image"></asp:Label></b>
        <br />
        <asp:Image ID="ImgAlbum" runat="server" Height="100" Width="100" />
        <br />
        <b><asp:Label ID="LblAlbumDesc" runat="server" Text="Album Description: "></asp:Label></b>
        <br />
        <div ID="DescContent">
            <asp:Label ID="AlbumDesc" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <b><asp:Label ID="LblAlbumPrice" runat="server" Text="Album Price: "></asp:Label></b>
        <asp:Label ID="AlbumPrice" runat="server" Text=""></asp:Label>
        <br />
        <b><asp:Label ID="LblAlbumStock" runat="server" Text="Album Stock: "></asp:Label></b>
        <asp:Label ID="AlbumStock" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblText" runat="server" Text="Are you sure you want to delete this album?"></asp:Label>
        <br />
            
        <asp:Button ID="BtnDelete" runat="server" Text="Delete Album" OnClick="BtnDelete_Click" />
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel Delete" OnClick="Cancel_Click" />
    </div>
</asp:Content>
