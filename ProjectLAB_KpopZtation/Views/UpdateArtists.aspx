<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateArtists.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.UpdateArtistsaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-around ">
            <div class="flex-left-gig">
                <h1><asp:Label ID="ItemLbl" runat="server"></asp:Label></h1>
                <asp:Image ID="ItemImage" runat="server" class="card-img-top title-hover" style="max-width:400px;"/>
                <h2><asp:Label ID="ItemPrice" runat="server"></asp:Label></h2>
            </div>
            <div class="flex-right-gig">
                <asp:Panel ID="BtnPanel" runat="server" >
                    <div class="d-flex flex-column ">
                        <asp:Label ID="ArtistNameLBL" runat="server" Text="Artist Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="ArtistNameTXT" runat="server"></asp:TextBox>
                        <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <br />
                        <asp:Label ID="ErrLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <br />
                        <asp:Button ID="EditBtn" runat="server" Visible="false" class="btn btn-primary mb-3" Text="Edit" OnClick="EditBtn_Click" />
                        <br />
                        <asp:Button ID="CancelBtn" runat="server" Visible="false" class="btn btn-outline-warning mb-3" Text="Cancel" OnClick="CancelBtn_Click1" />
             
                    </div>
                </asp:Panel>
            </div>
            
           
        </div>
</asp:Content>
