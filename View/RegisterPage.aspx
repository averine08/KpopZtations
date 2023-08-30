    <%@ Page Title="KpopZtation - Register" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .content{
            display: flex;
            width: 100%;
            justify-content: center;
            align-items: center;
            padding: 2rem 0;
        }

        .cb, .radio td{
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
            <h1>REGISTER</h1>

            <div style="display:flex;">
                <asp:Label ID="LblName" runat="server" Text="Name" CssClass="flex-item"></asp:Label>
                <asp:TextBox ID="TxtName" runat="server" CssClass="flex-item"></asp:TextBox>
            </div>

            <div style="display:flex;">
                <asp:Label ID="LblEmail" runat="server" Text="Email" CssClass="flex-item"></asp:Label>
                <asp:TextBox ID="TxtEmail" runat="server" CssClass="flex-item"></asp:TextBox>
            </div>

            <div style="display:flex;">
                <asp:Label ID="LblGender" runat="server" Text="Gender" CssClass="flex-item"></asp:Label>
                <asp:RadioButtonList ID="RBLGender" runat="server" CssClass="flex-item radio">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div style="display:flex;">
                <asp:Label ID="LblAddress" runat="server" Text="Address" CssClass="flex-item"></asp:Label>
                <asp:TextBox ID="TxtAddress" runat="server" CssClass="flex-item"></asp:TextBox>
            </div>

            <div style="display:flex;">
                <asp:Label ID="LblPassword" runat="server" Text="Password" CssClass="flex-item"></asp:Label>
                <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="flex-item"></asp:TextBox>
            </div>
            <div style="width:100%; display:flex; justify-content: flex-end;">
                <asp:Button ID="btnSeePassword" CssClass="btnSeePwd" runat="server" Text="See Password" OnClick="btnSeePassword_Click" />
            </div>
            <div>
                <asp:CheckBox ID="CBTerms" runat="server" Text="I Agree to the Terms and Conditions" CssClass="cb" />
            </div>

            <div>
                <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>

            <div>
                <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" />
            </div>
        </div>
    </div>
</asp:Content>
