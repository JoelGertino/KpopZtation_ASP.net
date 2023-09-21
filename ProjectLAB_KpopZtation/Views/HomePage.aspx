<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card-cloth {
          border: 1px solid black;
          display: flex;
          flex-direction: column;
          align-items: center;
          justify-content: center;
          text-align: center;
          height: auto;
          padding: 10px;
        }
        
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="p-5">
        <div class="all-gigs-section" style="margin: 0 3%">
            <h2 class="mb-4" style="font-size: 36px;">All Products</h2><br />
            <asp:Button ID="AddArtistBtn" runat="server" Text="Add Artist" OnClick="AddArtistBtn_Click" Visible="false" CssClass="btn btn-light" />
            <br />
            <div class="" style="display: grid; grid-template-columns: repeat(5, minmax(0, 1fr)); gap: 1rem;" id="post-data">
                <asp:Repeater ID="CardRepeater" runat="server">
                    <ItemTemplate>
                        <div class="card m-2 card-cloth" style="height:auto">
                            <asp:LinkButton ID="OpenDetail" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("ArtistId") %>' OnClick="OpenDetail_Click">
                                <img src="../Assets/Artists/<%# Eval("ArtistImage") %>" class="card-img-top title-hover" alt="...">
                                <p class="card-text title-hover" style="margin-top: 10px;"><%# Eval("ArtistName") %></p>
                            </asp:LinkButton>

                            <div class="HomeButton" id="ButtonContainer">
                                <asp:LinkButton ID="UpdateButton" runat="server" OnClick="UpdateButton_Click" CommandArgument='<%#Eval("ArtistID") %>' Style="cursor: pointer" Visible="false"  CssClass="btn btn-primary"> Update </asp:LinkButton>
                                <asp:LinkButton ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" CommandArgument='<%#Eval("ArtistID") %>' CssClass="btn btn-danger" Visible="false" > Delete </asp:LinkButton>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
    
    
</asp:Content>
