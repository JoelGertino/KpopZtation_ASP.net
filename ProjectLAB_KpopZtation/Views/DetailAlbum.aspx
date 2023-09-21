<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="DetailAlbum.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.DetailAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 2% 0% ">
        <div class="d-flex justify-content-around ">
            <div class="flex-left-gig">
                <h1><asp:Label ID="AlbumLBL" runat="server"></asp:Label></h1>
                <asp:Image ID="AlbumImage" runat="server" class="card-img-top title-hover" style="max-width:400px;"/>
            </div>
            <div class="flex-right-gig">
                <asp:Panel ID="BtnPanel" runat="server" >
                    <div class="d-flex flex-column ">
                        <asp:Label ID="AlbumDescLBL" runat="server" Text="Album Description"></asp:Label>
                        <br />
                        <asp:Label ID="AlbumPriceLBL" runat="server" Text="Album Price"></asp:Label>
                        <br />
                        <asp:Label ID="AlbumStockLBL" runat="server" Text="Album Stock"></asp:Label>
                        <br />

                        <asp:Label ID="QuantityLBL" runat="server" Text="Quantity"></asp:Label>
                        <asp:TextBox ID="QuantityTXT" runat="server"></asp:TextBox>

                        <br />
                        <asp:Label ID="Errlbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                        <br />
                        <asp:Button ID="AddCartBTN" runat="server" class="btn btn-success mb-3" Text="Add to Cart" OnClick="AddCartBTN_Click" />
                        <br />
                        <asp:Button ID="UpdateAlbumBTN" runat="server" Text="Update Album" class="btn btn-primary mb-3" Visible="false" OnClick="UpdateAlbumBTN_Click" />
                        <br />
                        <asp:Button ID="DeleteAlbumBTN" runat="server" Text="Delete Album" class="btn btn-outline-danger mb-3" Visible="false" OnClick="DeleteAlbumBTN_Click" />
                        <br />
                    </div>
                </asp:Panel>
            </div>
            
           
        </div>
     </div>
</asp:Content>
