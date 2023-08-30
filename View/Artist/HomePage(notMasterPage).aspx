<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage(notMasterPage).aspx.cs" Inherits="KpopZtation.View.Artist.HomePage_notMasterPage_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div>
            <h1> Welcome to Homepage</h1>
            <p>You can insert, delete, and update artist here</p>
        </div>
        <div>
            <p>isi grid view</p>
        </div>
        <div>
            <h1>Insert Artist</h1>
            <asp:Button ID="BtnInsertArtist" runat="server" Text="Insert Artist" />
        </div>
    </form>
</body>
</html>
