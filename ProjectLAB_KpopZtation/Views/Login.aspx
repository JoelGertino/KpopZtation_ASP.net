<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .button-container {
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

        .login-form {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            border: 1px solid #ccc;
            padding: 20px;
            width: 400px;
            margin: 0 auto;
        }

        .login-form Label {
            text-align: left;
            margin-bottom: 10px;
        }

        .login-form input[type="text"],
        .login-form input[type="password"] {
            width: 100%;
            padding: 5px;
            margin-bottom: 10px;
        }

        .login-form .error-label {
            color: red;
            margin-bottom: 10px;
            text-align: center;
        }

        .login-form .button-container {
            display: flex;
            flex-direction: column;
            align-items: flex-start;
            width: 100%;
        }

        .login-form .remember-container {
            display: flex;
            align-items: center;
        }

        .login-form .remember-container input[type="checkbox"] {
            margin-right: 5px;
        }

        .login-form button {
            padding: 10px 20px;
            background-color: #007bff;
            color: #fff;
            border: none;
            cursor: pointer;
            margin-bottom: 10px;
        }
        .register-container{
            display: flex;
            align-items: center;
            justify-content: center;
            margin-top: 10px;
        }

        .register-container label {
            margin-right: 5px;
        }

        .register-container button {
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-form">
        <h1 style="text-align: center;">Login</h1> 
        <br />
        <div class="button-container">
            <asp:Label ID="EmailLBL" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>

            <br />
            <asp:Label ID="PasswordLBL" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>

            <br />
            <div class="remember-container">
                <asp:CheckBox ID="RmbrMeBox" runat="server"/>
                <asp:Label ID="RmbrMeLbl" runat="server" Text="Remember Me"></asp:Label>
            </div>
            <br />
            <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>
            <br />
            <div class="container2">
                <asp:Button ID="LoginBtnn" runat="server" Text="Login" OnClick="LoginBtnn_Click" CssClass="full-width-button" />
                <div class="register-container">
                        <asp:Label ID="RegisterMessage" runat="server" Text="Doesn't have an account?" ForeColor="Gray"></asp:Label>
                        <asp:Button ID="RegisterBTN" runat="server" Text="Register" onclick="RegisterBTN_Click" CssClass="clickable-text-button" />
                </div>
            </div>
            
        </div>
    </div>
</asp:Content>
