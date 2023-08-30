<%@ Page Title="KpopZtation - Update Artist" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateArtistPage.aspx.cs" Inherits="KpopZtation.View.UpdateArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card{
            display:flex;
            justify-content:space-around;
            gap:1rem;
            
        }
        .card-right {
            display:flex;
            flex-basis:50%;
            flex-direction:column;
            gap:3px;
            background-color: #f9eeff;
            padding:1rem 2rem;

        }
        .card-left {
            display:flex;
            flex-direction:column;
            gap:3px;
            flex-basis:50%;
        }
        .btnUpdate {
            display:flex;
            justify-content:center;
            width:100%;
           
        }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="display:flex; width:max-content; justify-content:flex-start; padding:1rem 2rem;">
            <h2 class="btnBack"><a href='<%= ResolveUrl("/Home") %>'>< Back</a></h2>
        </div>
    <h1 style="text-align:center;">Update Artist Page</h1>
    <div style="margin:1rem 2rem; gap:5px; display:flex; flex-direction:column; align-items:center;">
        <div class="card">
            <div class="card-left">
                <h2>Artist Data</h2>
                <asp:Label ID="LblNameBefore" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TxtNameBefore" runat="server" Enabled="false"></asp:TextBox>
                <br />
                <asp:Label ID="LblImageBefore" runat="server" Text="Image"></asp:Label>
                <asp:Image ID="ImgBefore" runat="server" Height="100" Width="100" />
                <br />
            </div>
            <div class="card-right">
                <h2>New Artist Data</h2>
                <asp:Label ID="LblArtistName" runat="server" Text="Artist Name"></asp:Label>
                <asp:TextBox ID="TxtArtistName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="LblArtistImage" runat="server" Text="Artist Image"></asp:Label>
                <asp:FileUpload ID="ArtistImageFileUpload" runat="server" />
                <br />
                <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button CssClass="btnUpdate" ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
            </div>
        </div>

    </div>
</asp:Content>
