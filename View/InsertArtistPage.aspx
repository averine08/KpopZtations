<%@ Page Title="KpopZtation - Insert Artist" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertArtistPage.aspx.cs" Inherits="KpopZtation.View.InsertArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btnBack{
            color:black;
            font-size:1rem;
        }
        .btnBack:hover{
            text-decoration:underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" margin: 1rem 2rem;">
        <div style="display:flex; width:100%; justify-content:flex-start; padding:1rem 2rem;">
            <h2 class="btnBack"><a href='<%= ResolveUrl("/Home") %>'>< Back</a></h2>
        </div>
        <h1>Insert Artist Page</h1>
        <div>
            <asp:Label ID="LblArtistName" runat="server" Text="Artist Name"></asp:Label>
            <asp:TextBox ID="TxtArtistName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LblArtistImage" runat="server" Text="Artist Image"></asp:Label>
            <br />
            <asp:FileUpload ID="ArtistImageFileUpload" runat="server" />
            <br />
            <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
            <br />

            <asp:Button ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click" />
        </div>

    </div>
</asp:Content>
