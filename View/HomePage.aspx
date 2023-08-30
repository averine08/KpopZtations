<%@ Page Title="KpopZtation - View Artists" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <style>
        #LinkContainer {
            display: flex;
            width: inherit;
            justify-content: space-between;
        }

        .insert-button{
            display: flex;
            justify-content: center;
            border:none;
            background-color:#247073;
            font-size:1.05rem;
            color:white;
            padding: 4px 8px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 1rem 2rem; display: flex; flex-direction: column; align-items: center; gap:10px">
        <h1>Home Page</h1>
        <% if (cust != null){ %>
            <% if (cust.CustomerRole.Equals("ADM")){ %>
                <asp:Button ID="BtnInsert" runat="server" Text="Insert Artist" OnClick="BtnInsert_Click" CssClass="insert-button" />
            <% } %>
        <% } %>

        
        <div style="display: flex; width: 100%; flex-wrap: wrap; padding: 2rem 0; gap: 1rem; justify-content:center;"> 
            <% foreach (var artist in artistList){%>
            <div  style="display:flex; flex-direction: column; align-items: center; flex-wrap:wrap; background-color:#eae4fb">
                <a href='<%= ResolveUrl("/ArtistDetails") + "?ArtistID=" + artist.ArtistID %>' style=" display:flex; flex-direction:column;flex-basis: 19.9%; padding: 20px 15px; background-color:#eae4fb; gap:3px; align-items:center; color:black">
                    <% GetImageUrl(artist);%>
                    <asp:Image ID="Image1" runat="server" Height="100" Width="100"/>
                        
                <p><%= artist.ArtistName %></p>
                </a>
                <% if (cust != null ){ %>
                    <% if (cust.CustomerRole.Equals("ADM")){%>
                        <div id="LinkContainer" style="width:100%; display:flex; justify-content:space-between">
                            <a href='<%= ResolveUrl("/UpdateArtist") + "?ArtistID=" + artist.ArtistID %>' style="background-color:#7341b2; color:white; font-size:0.8rem ; padding:4px 6px;" >Update</a>
                            <a href='<%= ResolveUrl("/DeleteArtist") + "?ArtistID=" + artist.ArtistID %>' style="background-color:#b24152; color:white; font-size:0.8rem ; padding:4px 6px;">Delete</a>
                        </div>
                    <%} %>
                <% } %>
            </div>
            <% }%>
            <% if(artistList.Count() == 0){%>
                <asp:Label ID="lblNoalbum" runat="server" Text="No Artists in Database"></asp:Label>
            <% }%>
        </div>
       </div>
        
    
</asp:Content>