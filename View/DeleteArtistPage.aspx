<%@ Page Title="KpopZtation - Delete Artist" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="DeleteArtistPage.aspx.cs" Inherits="KpopZtation.View.DeleteArtistPage" %>
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
        <div style="display:flex; justify-content:flex-start; padding:1rem 2rem;">
            <h2 class="btnBack"><a href='<%= ResolveUrl("/Home") %>'>< Back</a></h2>
        </div>
        <h1>Delete Artist Page</h1>
        <asp:Label ID="LblArtistName" runat="server" Text="Artist Name"></asp:Label>
        <asp:TextBox ID="TxtArtistName" runat="server" Enabled="false"></asp:TextBox>
        <br />
        <asp:Label ID="LblArtistImage" runat="server" Text="Artist Image"></asp:Label>
        <br />
        <asp:Image ID="ImgArtist" runat="server" Height="100" Width="100" />
        <br />
        <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
        <br />
            
        <asp:Button ID="BtnDelete" runat="server" Text="Delete Artist" OnClick="BtnDelete_Click" />
    </div>
</asp:Content>
