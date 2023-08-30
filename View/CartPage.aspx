<%@ Page Title="KpopZtation - Cart" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #th, td{
            border: 1px solid black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:40px">
        <h1>Cart Page</h1>

        <asp:ListView ID="LVAlbumList" runat="server">
            <LayoutTemplate>
                <table>
                    <tr style="border:solid 1px black">
                        <th><b>Album's Picture</b></th>
                        <th><b>Album's Name</b></th>
                        <th><b>Album's Qty</b></th>
                        <th><b>Album's Price</b></th>
                        <th><b>SubTotal</b></th>
                        <th>Action</th>
                    </tr>
                    <tr id="itemPlaceholder" runat="server"></tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                        <td>
                        <img style="width:200px; height:200px"  ID="albumImage" src="../Assets/Albums/<%# Eval("Album.AlbumImage")%>"/>
                        </td>
                        <td>
                            <asp:Label ID="LblAlbumName" runat="server"><%# Eval("Album.AlbumName") %></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="LblItemQty" runat="server"><%# Eval("Qty") %></asp:Label>
                          
                        </td>
                        <td>
                            <asp:Label ID="LblAlbumPrice" runat="server"><%# "Rp " + Eval("Album.AlbumPrice")%></asp:Label>
                          
                        </td>
                        <td>
                            <asp:Label ID="LblSubTotal" runat="server" Text='<%# "Rp " +  (Convert.ToInt32(Eval("Album.AlbumPrice")) * Convert.ToInt32(Eval("Qty"))).ToString() %>'></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" CommandArgument= '<%#Eval("AlbumID")%>'>Remove</asp:LinkButton>
                        </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <br />
        <asp:Label ID="LblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="BtnCheckOut" runat="server" Text="Check Out" OnClick="BtnCheckOut_Click" />
            <asp:Button ID="BtnBackToHome" runat="server" Text="Go Back to Home" OnClick="BtnBackToHome_Click"/>
        </div>
</asp:Content>
