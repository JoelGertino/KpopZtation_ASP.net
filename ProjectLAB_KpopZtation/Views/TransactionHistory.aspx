<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Transaction ID</th>
                    <th scope="col">Transaction Date</th>
                    <th scope="col">Customer Name</th>
                    <th scope="col">Album Picture</th>
                    <th scope="col">Album Name</th>          
                    <th scope="col">Album Quantity</th>
                    <th scope="col">Album Price</th>
                    
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="TableRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td scope="row"><%# Eval("TransactionID") %></td>
                            <td scope="row"><%# Eval("TransactionDate") %></td>
                            <td scope="row"><%# Eval("CustomerName") %></td>
                            <td scope="row">
                                <img src="../Assets/Albums/<%# Eval("AlbumImage") %>"  style="max-width:200px" alt="Album Image" />
                            </td>
                            <td scope="row"><%# Eval("AlbumName") %></td>
                            <td scope="row"><%# Eval("Qty") %></td>
                            <td scope="row"><%# Eval("AlbumPrice") %></td>
                            
                            
                            
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
