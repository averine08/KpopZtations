<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZtation.View.InsertAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>INSERT ALBUM</h1>

            <asp:Label ID="LblAlbumName" runat="server" Text="Album Name"></asp:Label>
            <asp:TextBox ID="TxtAlbumName" runat="server"></asp:TextBox>

            <asp:Label ID="lblAlbumDesc" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>




        </div>
    </form>
</body>
</html>
