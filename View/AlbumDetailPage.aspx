<%@ Page Title="KpopZtation - Album Detail" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="AlbumDetailPage.aspx.cs" Inherits="KpopZtation.View.AlbumDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btnBack{
            color:black;
            font-size:1rem;
        }
        .btnBack:hover{
            text-decoration:underline;
        }
        .content{
            display:flex;
            flex-direction:column;
            align-items:center;
            margin:1rem 2rem; 
            font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', 'Geneva', 'Verdana', 'sans-serif';
        }
        .card{
            display:flex;
            padding: 1.7rem 2rem;
            gap:1rem;
            background-color:#f9eeff;
            align-items:center;
            justify-content:space-around;

        }
        .card-right{
            display:flex;
            flex-direction:column;
            justify-content:center;
            gap:5px;
            width:60%;

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div style="display:flex; width:100%; justify-content:flex-start;">
            <h2 class="btnBack"><a href='<%= ResolveUrl("/artistdetails") + "?ArtistID=" + artistID %>'>< Back</a></h2>
        </div>

        <h1>Album Detail Page</h1>
        <div class="card">
            <asp:Image ID="Image1" runat="server" Height="200" Width="200"/>
            <div class="card-right">
                <p><b>Album's Name</b> : <%= albumObject.AlbumName %></p>
                 <p><b>Album's Description</b> : </p>
                <p>     <%= albumObject.AlbumDescription %></p>

                 <p><b>Album's Price</b> : <%= albumObject.AlbumPrice %></p>
                 <p><b>Album Name's Stock</b> : <%= albumObject.AlbumStock %></p>

                <% if (cust != null ){ %>
                    <% if (cust.CustomerRole.Equals("CST")){%>
                               
                        <asp:Label ID="LblQuantity" runat="server" Text="Quantity"></asp:Label>
                        <asp:TextBox ID="TxtQuantity" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Button ID="BtnAddToCart" runat="server" Text="Add to Cart" OnClick="BtnAddToCart_Click" />
                    <%} %>
                <% } %>
             </div>
         </div>
    </div>
</asp:Content>