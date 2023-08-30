<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertArtistPage.aspx.cs" Inherits="KpopZtation.View.Artist.InsertArtistPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div>
            <h1>INSERT ARTIST PAGE</h1>
            <br />
            <asp:Label ID="LblArtistName" runat="server" Text="Artist Name"></asp:Label>
            <asp:TextBox ID="TxtArtistName" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="LblArtistImage" runat="server" Text="Artist Image"></asp:Label>
            <asp:FileUpload ID="ImgArtist" runat="server" />
            <br />
            <asp:Button ID="BtnInsertArtist" runat="server" Text="Insert Artist" OnClick="BtnInsertArtist_Click"/>

            <asp:Label ID="lblView" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
