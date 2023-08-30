<%@ Page Title="KpopZtation - View Albums" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArtistDetailPage.aspx.cs" Inherits="KpopZtation.View.ArtistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #LinkContainer {
            display: flex;
            width: inherit;
            gap: 20px;
            
        }

        .insert-button{
            display: flex;
            width: fit-content;
            align-self: center;
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
    <div style="display:flex; flex-direction:column; align-items:center; margin:1rem 2rem; gap:5px; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">
        <div style="display:flex; width:100%; justify-content:flex-start;">
            <h2 class="btnBack"><a href="/View/HomePage.aspx">< Back</a></h2>

        </div>        
        <h1>Artist Detail Page</h1>
        <br />
        <asp:Image ID="Image1" runat="server" Height="200" Width="200"/>
        <p>Artist Name : <%= artistObject.ArtistName %></p>
        <br />
        <h2>Album Details</h2>
         <% if (cust != null && cust.CustomerRole.Equals("ADM"))
            { %>
            <asp:Button ID="BtnInsert" runat="server" Text="Insert Album" OnClick="BtnInsert_Click" CssClass="insert-button" />
        <% } %>
        <%--<asp:GridView ID="GVAlbums" runat="server" AutoGenerateColumns="False" DataKeyNames="AlbumID" CellPadding="5">
            <Columns>
                <asp:BoundField DataField="AlbumID" HeaderText="ID" InsertVisible="False" Visible="False" />
                <asp:BoundField DataField="AlbumName" HeaderText="Name" />
                <asp:BoundField DataField="AlbumPrice" HeaderText="Price" />
                <asp:BoundField DataField="AlbumDescription" HeaderText="Description" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="imageControl" runat="server" Height="100" Width="100" ImageUrl='<%# "~/Assets/Albums/"+ Eval("AlbumImage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>--%>
        <div style="display: flex; flex-direction: column;padding: 2rem 0; gap: 1.5rem;">
            <div style="display: flex; width: 100%; gap: 1rem; flex-wrap: wrap;">
                <%if (albumList.Count == 0)
                    { %>    
                    <asp:Label ID="lblNoalbum" runat="server" Text="No Album in Database"></asp:Label>
                    <%} %>
                <% foreach (var album in albumList)
                    {%>
                
                    <div style="display: flex; flex-basis: 24.4%; flex-wrap: wrap; padding: 1rem 0; gap: 3px; flex-direction: column; align-items: center;  background-color:#eae4fb; justify-content:space-between">
                        <a href='<%= ResolveUrl("/AlbumDetails") + "?AlbumID=" + album.AlbumID %>'  style=" display:flex; flex-direction:column; padding: 20px 15px; background-color:#eae4fb; gap:3px; align-items:center; color:black">
                        <% GetImageUrl(album); %>
                        <asp:Image ID="Image2" runat="server" Height="150" Width="150" />
                        <p><%= album.AlbumName %></p>
                        <p>Rp. <%= album.AlbumPrice %></p>
                        <br />
                        <p style="align-self:start"><b>Album Description:</b></p>
                        <p><%= album.AlbumDescription %></p>
                        </a>
                    <% if (cust != null ){ %>
                        <% if (cust.CustomerRole.Equals("ADM")){%>
                            <div id="LinkContainer">
                                <a href='<%= ResolveUrl("/UpdateAlbum") + "?AlbumID=" + album.AlbumID + "&ArtistID=" + ArtistID.ToString() %>'  style="background-color:#7341b2; color:white; font-size:0.8rem ; padding:4px 6px;">Update</a>
                                <a href='<%= ResolveUrl("/DeleteAlbum") + "?AlbumID=" + album.AlbumID + "&ArtistID=" + ArtistID.ToString() %>' style="background-color:#b24152; color:white; font-size:0.8rem ; padding:4px 6px;">Delete</a>
                            </div>
                        <%} %>
                    <% } %>
                    </div>
                    
                
                <% }%>
            </div>


        </div>
    </div>
</asp:Content>