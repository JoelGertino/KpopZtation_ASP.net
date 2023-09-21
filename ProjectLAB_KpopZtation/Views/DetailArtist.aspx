<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="DetailArtist.aspx.cs" Inherits="ProjectLAB_KpopZtation.Views.DetailArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .label-text {
            text-decoration: none;
            color: black;
        }

        .label-text:hover {
            text-decoration: none;
            color: black;
        }

        .title-hover {
            text-decoration: none;
            color: black;
        }

        .title-hover:hover {
            text-decoration: underline;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin: 2% 0% ">
        <div class="d-flex justify-content-around ">
            <div class="flex-left-gig">
                <h1><asp:Label ID="ItemLbl" runat="server"></asp:Label></h1>
                <asp:Image ID="ItemImage" runat="server" class="card-img-top title-hover" style="max-width:400px;"/>
                <h2><asp:Label ID="ItemPrice" runat="server"></asp:Label></h2>
            </div>
            <div class="flex-right-gig">
                <asp:Panel ID="BtnPanel" runat="server" Visible="false">
                    <div class="d-flex flex-column ">
                        <!--
                        <asp:Label ID="ArtistNameLBL" runat="server" Text="Artist Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="ArtistNameTXT" runat="server"></asp:TextBox>
                        <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <br />
                            -->
                        <asp:Label ID="ErrLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <br />
                        <asp:Button ID="UpdateBtn" runat="server" Cssclass="btn btn-primary mb-3" Text="Update Artist" OnClick="UpdateBtn_Click" />
                        <br />
                        <asp:Button ID="DeleteBtn" runat="server" Cssclass="btn btn-outline-danger" Text="Delete" OnClick="DeleteBtn_Click" />
                    </div>
                </asp:Panel>
            </div>
            
           
        </div>
         
         <div style="text-align: center; margin-top: 20px;">
            <h3>Artist's Album</h3>
             <asp:Button ID="AddAlbumBtn" runat="server" Text="Add Album" OnClick="AddAlbumBtn_Click1" Visible="false" Cssclass="btn btn-light"/> 
            
        </div>

        <div class="" style="display: grid; grid-template-columns: repeat(5, minmax(0, 1fr)); gap: 1rem;"
                id="post-data">

                <asp:Repeater ID="CardRepeater" runat="server">
                    <ItemTemplate>
                        <div class="card m-2 card-cloth">
                            <asp:LinkButton ID="AlbumDetail" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("AlbumID") %>' OnClick="AlbumDetail_Click">
                                <div>
                                    <p>
                                        <img src="../Assets/Albums/<%# Eval("AlbumImage") %>" class="card-img-top" alt="...">
                                    </p>
                                    <div class="card-body">
                                        <asp:Label ID="Label2" runat="server" Text="AlbumName : " CssClass="label-text"></asp:Label>
                                        <p class="card-text title-hover"><%# Eval("AlbumName") %></p><br />

                                        <asp:Label ID="Label3" runat="server" Text="AlbumPrice : " CssClass="label-text"></asp:Label>
                                        <p class="card-text title-hover"><%# Eval("AlbumPrice") %></p><br />

                                        <asp:Label ID="Label4" runat="server" Text="AlbumStock : " CssClass="label-text"></asp:Label>
                                        <p class="card-text title-hover"><%# Eval("AlbumStock") %></p><br />

                                        <asp:Label ID="Label5" runat="server" Text="AlbumDescription : " CssClass="label-text"></asp:Label>
                                        <p class="card-text title-hover"><%# Eval("AlbumDescription") %></p><br />
                                    </div>
                                    
                                </div>
                            </asp:LinkButton>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
         <br />
         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
</asp:Content>
