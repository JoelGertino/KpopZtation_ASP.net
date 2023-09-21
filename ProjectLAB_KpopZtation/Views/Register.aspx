<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .register-form {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        border: 1px solid #ccc;
        padding: 20px;
        width: 400px;
        margin: 0 auto;
    }

    .register-form h1 {
        text-align: center;
    }

    .register-form Label {
        text-align: left;
        margin-bottom: 10px;
    }

    .register-form input[type="text"],
    .register-form input[type="password"] {
        width: 100%;
        padding: 5px;
        margin-bottom: 10px;
    }

    .register-form .error-label {
        color: red;
        margin-bottom: 10px;
        text-align: center;
    }

    .register-form .button-container {
        display: flex;
        flex-direction: column;
        align-items: flex-start;
        width: 100%;
    }

    
    .full-width-button {
        width: 100%;
        padding: 10px 20px;
        background-color: #007bff;
        color: #fff;
        border: none;
        cursor: pointer;
        margin-bottom: 10px;
    }

    .login-container {
        display: flex;
        align-items: center;
        justify-content: center;
        margin-top: 10px;
    }

    .login-container label {
        margin-right: 5px;
    }

    .login-container button {
        margin-bottom: 10px;
    }

    .clickable-text-button {
        background-color: transparent;
        color: #007bff;
        border: none;
        cursor: pointer;
    }

    .container2 {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        width: 100%;
    }

    .container2 .full-width-button {
        width: 100%;
    }

</style>

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="register-form">
        <h1>Register</h1>
        <br />
        <div class="button-container">
            <asp:Label ID="NameLBL" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="EmailLBL" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="EmailTXT" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="GenderLBL" runat="server" Text="Gender:"></asp:Label>
            <asp:RadioButtonList ID="GenderRadioList" runat="server" RepeatDirection="Vertical" OnSelectedIndexChanged="GenderRadioList_SelectedIndexChanged">
                <asp:ListItem ID="MalesList">Male</asp:ListItem>
                <asp:ListItem ID="FemaleList">Female</asp:ListItem>
            </asp:RadioButtonList>

            <br />
            <asp:Label ID="AddressLBL" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="AddressTXT" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="PasswordLBL" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="PasswordTXT" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="ErrorLBL" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <div class="container2">
                <asp:Button ID="RegisterBTN" runat="server" Text="Register" onclick="RegisterBTN_Click" CssClass="full-width-button" />
                <div class="login-container">
                    <asp:Label ID="LoginMessage" runat="server" Text="Already have an account?" ForeColor="Gray"></asp:Label>
                    <asp:Button ID="LoginBTN" runat="server" Text="Login" onclick="LoginBTN_Click" CssClass="clickable-text-button" />
                </div>
            </div>
            
        </div>
    </div>
</asp:Content>