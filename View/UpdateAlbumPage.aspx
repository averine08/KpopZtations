<%@ Page Title="KpopZtation - Update Album" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateAlbumPage.aspx.cs" Inherits="KpopZtation.View.UpdateAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .card{
            display:flex;
            justify-content:space-around;
            gap:1rem;
            
        }
        #AlbumFieldBefore {
            display:flex;
            flex-direction:column;
            gap:3px;
            width:50%;
            padding:1rem 2rem;
        }

        #AlbumFieldAfter {
            display:flex;
            width:50%;
            flex-direction:column;
            gap:3px;
            background-color: #f9eeff;
            padding:1rem 2rem;
        }

        .FieldContent{
            margin: 10px;
        }
        #BtnInsertContainer{
            justify-self: center;
            width: fit-content;
        }
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
     <div>
        <div style="display:flex; width:100%; justify-content:flex-start; padding:1rem 2rem;">
            <h2 class="btnBack"><a href='<%= ResolveUrl("/ArtistDetails") + "?ArtistID=" + artistID %>'>< Back</a></h2>
        </div>
            <h1 style="text-align:center;">UPDATE ALBUM</h1>
         <br />
         <div class="card">
            <div id="AlbumFieldBefore">
                    <h2>Selected Album to be Updated</h2>
            
                    <b><asp:Label ID="LblAlbumName" runat="server" Text="Album Name: "></asp:Label></b>
                    <asp:Label ID="TxtAlbumNameBefore" runat="server" Text=""></asp:Label>
            
            
                    <b><asp:Label ID="lblAlbumDesc" runat="server" Text="Album Description: "></asp:Label></b>
                    <asp:Label ID="TxtAlbumDescBefore" runat="server" Text=""></asp:Label>
            
            
                    <b><asp:Label ID="LblPrice" runat="server" Text="Price: "></asp:Label></b>
                    <asp:Label ID="TxtPriceBefore" runat="server" Text=""></asp:Label>
            
                    <b><asp:Label ID="LblStock" runat="server" Text="Stock: "></asp:Label></b>
                    <asp:Label ID="TxtStockBefore" runat="server" Text=""></asp:Label>
            
                    <asp:Label ID="LblImageUpload" runat="server" Text="Album Image"></asp:Label>
                    <br />
                    <asp:Image ID="ImageBefore" runat="server" Height="200" Width="200" />
                </div>
            


            <div id="AlbumFieldAfter">
             <h2>New Album Data Input</h2>
                
                    <asp:Label ID="Label1" runat="server" Text="Album Name"></asp:Label>
                    <asp:TextBox ID="TxtAlbumNameAfter" runat="server"></asp:TextBox>

                    <asp:Label ID="Label2" runat="server" Text="Album Description"></asp:Label>
                    <br />
                    <asp:TextBox ID="TxtDescAfter" runat="server" ></asp:TextBox>

                    <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
                    <asp:TextBox ID="TxtPriceAfter" runat="server"></asp:TextBox>

                    <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
                    <asp:TextBox ID="TxtStockAfter" runat="server"></asp:TextBox>
         
                    <asp:Label ID="Label5" runat="server" Text="Album Image"></asp:Label>
                    <br />
                    <asp:FileUpload ID="AlbumImageFileUpload" runat="server" />

            
                <div id="BtnInsertContainer">
                    <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
                </div>
            </div>
         </div>
    </div>
</asp:Content>

