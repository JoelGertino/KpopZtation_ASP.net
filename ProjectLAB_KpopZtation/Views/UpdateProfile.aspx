<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            width: 250px; 
            margin: 10px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .heading {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div>
            <h1 class="heading">Customer Table</h1>
        </div>

        <div>
            <asp:Label ID="NameLBL" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
            <asp:Button ID="NameButton" runat="server" Text="Update" OnClick="NameButton_Click" CssClass="btn btn-warning"/>
            <asp:Label ID="ErrNameLbl" runat="server" Text="" Forecolor="Red"></asp:Label>

            <br />
            <asp:Label ID="EmailLBL" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="EmailTXT" runat="server"></asp:TextBox>
            <asp:Button ID="EmailButton" runat="server" Text="Update" OnClick="EmailButton_Click" CssClass="btn btn-warning" />
            <asp:Label ID="ErrEmailLbl" runat="server" Text="" Forecolor="Red"></asp:Label>

            <br />
            <asp:Label ID="GenderLBL" runat="server" Text="Gender:"></asp:Label>
            <br />
            <asp:RadioButtonList ID="GenderRadio" runat="server" RepeatDirection="Vertical" OnSelectedIndexChanged="GenderRadio_SelectedIndexChanged">
                <asp:ListItem ID="MalesList">Male</asp:ListItem>
                <asp:ListItem ID="FemaleList">Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="GenderButton" runat="server" Text="Update" OnClick="GenderButton_Click" CssClass="btn btn-warning" />
            <asp:Label ID="ErrGenderLbl" runat="server" Text="" Forecolor="Red"></asp:Label>

            <br />
            <asp:Label ID="AddressLBL" runat="server" Text="Address:"></asp:Label>
            <br />
            <asp:TextBox ID="AddressTXT" runat="server"></asp:TextBox>
            <asp:Button ID="AddressButton" runat="server" Text="Update" OnClick="AddressButton_Click" CssClass="btn btn-warning" />
            <asp:Label ID="ErrAddressLbl" runat="server" Text="" Forecolor="Red"></asp:Label>

            <br />
            <asp:Label ID="PasswordLBL" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox ID="PasswordTXT" runat="server"></asp:TextBox>
            <asp:Button ID="PasswordButton" runat="server" Text="Update" OnClick="PasswordButton_Click" CssClass="btn btn-warning"/>
            <asp:Label ID="ErrPasswordLbl" runat="server" Text="" Forecolor="Red"></asp:Label>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
