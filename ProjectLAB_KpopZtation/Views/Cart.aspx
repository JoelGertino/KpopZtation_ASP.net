<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="padding:2% 10%">
        
        <table class="table">
           
            <thead>
                <tr>
                    <th scope="col">Album Name</th>
                    <th scope="col">Album Image</th>
                    <th scope="col">Album Quantity</th>
                    <th scope="col">Album Price</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="CardRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td scope="row"><%# Eval("AlbumName") %></td>
                            <td scope="row">
                                <img src="../Assets/Albums/<%# Eval("AlbumImage") %>"  style="max-width:200px" alt="Album Image" />
                            </td>
                            <td scope="row"><%# Eval("Quantity") %></td>
                            <td scope="row">$<%# Eval("AlbumPrice") %></td>
                     
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" class="btn btn-success w-100 mt-2" OnClick="CheckoutBtn_Click"/>
        
    </div>
</asp:Content>
