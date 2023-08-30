<%@ Page Title="KpopZtation - Transaction Details" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="TransactionDetailsPage.aspx.cs" Inherits="KpopZtation.View.TransactionDetailsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table{
            width: 100%;
        }

        th, td {
            background: rgb(255 180 98);
            padding: 20px;
            border: 1px solid black;
        }

        th:first-of-type {
            border-radius: 1em 0 0 0;
        }

        th:last-of-type {
            border-radius: 0 1em 0 0;
        }

        tr:last-of-type td:last-of-type {
            border-radius: 0 0 1em 0;
        }

        tr:last-of-type td:first-of-type {
            border-radius: 0 0 0 1em;
        }

        .flex-item{
            width: 50%;
        }

        .flex-container{
            display: flex;
            width: 50%;
            padding: 0 1rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 1.5rem 0; text-align: center;">
        <h1>Transaction Details</h1>
    </div>
    <div style="padding: 1.5rem 1.5rem;">
        <div style="width: 80%;">
            <div class="flex-container">
                <div class="flex-item">Transaction ID:</div>
                <div class="flex-item"><%= tran.TransactionID %></div>
            </div>

            <div class="flex-container">
                <div class="flex-item">Transaction Date:</div>
                <div class="flex-item"><%= tran.TransactionDate.ToString("dddd, dd MMMM yyyy") %></div>
            </div>

            <div class="flex-container">
                <div class="flex-item">Customer Name:</div>
                <div class="flex-item"><%= tran.Customer.CustomerName %></div>
            </div>
        </div>

        <br />

        <table>
            <thead>
                <tr>
                    <th>Album Image</th>
                    <th>Album Name</th>
                    <th>Album Quantity</th>
                    <th>Album Price</th>
                    <th>Sub Total</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var tranDet in tran.TransactionDetails)
                { %>
                <tr>
                    <td>
                        <% GetImageUrl(tranDet.Album.AlbumImage); %>
                        <asp:Image ID="Image1" runat="server" Height="100" Width="100" />
                    </td>
                    <td><%= tranDet.Album.AlbumName %></td>
                    <td><%= tranDet.Qty %></td>
                    <td><%= "Rp " + tranDet.Album.AlbumPrice %></td>
                    <td><%= "Rp " + (tranDet.Qty * tranDet.Album.AlbumPrice) %></td>
                </tr>
                <% } %>
                <tr>
                    <td colspan="4" style="text-align: center">Total</td>
                    <td><%= "Rp " + tran.TransactionDetails.Sum(x => x.Album.AlbumPrice * x.Qty) %></td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
