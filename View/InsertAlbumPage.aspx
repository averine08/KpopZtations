<%@ Page Title="KpopZtation - Insert Album" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertAlbumPage.aspx.cs" Inherits="KpopZtation.View.InsertAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #AlbumField {
            display: flex;
            align-content: center;
            justify-content: flex-start;
            flex-direction: column;
        }
        .FieldContent{
            margin: 10px;
        }
        #BtnInsertContainer{
            justify-self: center;
            width: fit-content;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="display:flex;justify-content:flex-start; padding:1rem 2rem;">
            <h2 class="btnBack"><a href='<%= ResolveUrl("/ArtistDetails") + "?ArtistID=" + ArtistID %>'>< Back</a></h2>
        </div>
        <h1>INSERT ALBUM</h1>

        <div id="AlbumField">
            <div class="FieldContent">
                <asp:Label ID="LblAlbumName" runat="server" Text="Album Name"></asp:Label>
                <asp:TextBox ID="TxtAlbumName" runat="server"></asp:TextBox>
            </div>
            <div class="FieldContent">
                <asp:Label ID="lblAlbumDesc" runat="server" Text="Album Description"></asp:Label>
                <br />
                <asp:TextBox ID="TxtAlbumDesc" runat="server" Width="875px" ></asp:TextBox>
            </div>
            <div class="FieldContent">
                <asp:Label ID="LblPrice" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="TxtPrice" runat="server"></asp:TextBox>
            </div>
            <div class="FieldContent">
                <asp:Label ID="LblStock" runat="server" Text="Stock"></asp:Label>
                <asp:TextBox ID="TxtStock" runat="server"></asp:TextBox>
            </div>
            <div class="FieldContent">
                <asp:Label ID="LblImageUpload" runat="server" Text="Album Image"></asp:Label>
                <br />
                <asp:FileUpload ID="AlbumImageFileUpload" runat="server" />
            </div>
            
            <div id="BtnInsertContainer">
                <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click" />
            </div>
            
            
        </div>
        
    </div>
</asp:Content>

