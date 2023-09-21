<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="AddArtists.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.AddArtists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin-top: 50px;
        }

        .form-container {
            display: flex;
            flex-direction: column;
            align-items: flex-start;
            margin-top: 20px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            width: 400px;
        }

        .form-container label {
            text-align: left;
            align-items: flex-start;
            margin-bottom: 10px;
        }

        .form-container input[type="text"],
        .form-container input[type="file"],
        .form-container input[type="submit"],
        .form-container input[type="button"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            box-sizing: border-box;
        }

        .centered-heading {
            text-align: center;
        }

        .heading-container {
            width: 100%;
            display: flex;
            justify-content: center;
            margin-bottom: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-container">
            <div class="heading-container">
                <h2 class="centered-heading">Add Artist</h2>
            </div>

            <asp:Label ID="ArtistNameLBL" runat="server" Text="Artist Name"></asp:Label>
            <asp:TextBox ID="ArtistNameTXT" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="ArtistImageLBL" runat="server" Text="Artist Image"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />

            <br />
            <asp:Label ID="ErrLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="SubmitBTN" runat="server" Text="Submit" CssClass="btn btn-primary mb-3" OnClick="SubmitBTN_Click" />
            <br />
            <asp:Button ID="CancelBTN" runat="server" Text="Cancel" Cssclass="btn btn-outline-danger mb-3" OnClick="CancelBTN_Click" />
        </div>
    </div>
</asp:Content>
