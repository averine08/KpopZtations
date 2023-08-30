<%@ Page Title="KpopZtation - Login" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KpopZtation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .content{
            display: flex;
            width: 100%;
            justify-content: center;
            align-items: center;
            padding: 2rem 0;
        }

        .cb{
            display:flex;gap: 0.5rem;
        }

        .flex-item{
            width:50%;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
        <div style="display:flex; flex-direction:column;gap:10px;border: 1px solid black;padding: 25px;width: 40%;">
            <h1>LOGIN</h1>
            <div style="display:flex; flex-direction: column; gap:10px; width:100%; overflow:hidden">
                <div style="display:flex; gap:10px;">
                    <asp:Label ID="LblEmail" runat="server" Text="Email" CssClass="flex-item"></asp:Label>
                    <asp:Label ID="LblPassword" runat="server" Text="Password" CssClass="flex-item"></asp:Label>
                </div>

                <div style="display:flex; gap:10px;">
                    <asp:TextBox ID="TxtEmail" runat="server" CssClass="flex-item"></asp:TextBox>
                    <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="flex-item" EnableViewState="true"></asp:TextBox>
                </div>
                <div style="width:100%; display:flex; justify-content: flex-end;">
                    <asp:Button ID="btnSeePassword" CssClass="btnSeePwd" runat="server" Text="See Password" OnClick="btnSeePassword_Click" />
                </div>
            </div>

            <div>
                <asp:CheckBox ID="CBRemember" runat="server" Text="Remember Me" CssClass="cb" />
            </div>

            <div>
                <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>

            <div>
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
            </div>
        </div>
    </div>
</asp:Content>
