<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.UpdateAlbum" %>
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
                        <asp:Label ID="AlbumNameLBL" runat="server" Text="Album Name"></asp:Label>
                        <asp:TextBox ID="AlbumNameTxt" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="AlbumDescLBL" runat="server" Text="Album Description"></asp:Label>
                        <asp:TextBox ID="AlbumDescTxt" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="AlbumPriceLBL" runat="server" Text="Album Price"></asp:Label>
                        <asp:TextBox ID="AlbumPriceTxt" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="AlbumStockLBL" runat="server" Text="Album Stock"></asp:Label>
                        <asp:TextBox ID="AlbumStockTxt" runat="server"></asp:TextBox>               
                        <br />
                        <asp:Label ID="AlbumImageLBL" runat="server" Text="Album Image"></asp:Label>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <br />
                        <asp:Label ID="Errlbl" runat="server" Text=""></asp:Label>
                        <br />

                        <asp:Button ID="UpdateBTN" runat="server" Text="Update" OnClick="UpdateBTN_Click" />
                        <asp:Button ID="CancelBTN" runat="server" Text="Cancel" OnClick="CancelBTN_Click" />

                        <br />
                    </div>
                </asp:Panel>
            </div>
            
           
        </div>
       
     </div>
</asp:Content>
