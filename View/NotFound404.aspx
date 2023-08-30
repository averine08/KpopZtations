<%@ Page Title="KpopZtation - Page Not Found" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="NotFound404.aspx.cs" Inherits="KpopZtation.View.NotFound404" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="text-align: center; padding: 1.5rem 0">
    <h1>404</h1>
    <h2>Page Not Found</h2>
</div>
<div style="display: flex; justify-content: center;">
    <asp:Button ID="BtnHome" runat="server" Text="Go Back to Home" OnClick="BtnHome_Click" />
</div>
</asp:Content>
