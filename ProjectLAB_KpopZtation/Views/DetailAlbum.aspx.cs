using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLAB_KpopZtation.Controller;
using ProjectLAB_KpopZtation.Model;

namespace ProjectLAB_KpopZtation.Views
{
    public partial class DetailAlbum : System.Web.UI.Page
    {
        AlbumController AC = new AlbumController();
        CartController CC = new CartController();
        protected void Page_Load(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(Request.QueryString["AlbumID"]);
            Album albumid = AC.getAlbumID(id);
            AlbumLBL.Text = albumid.AlbumName;
            AlbumImage.ImageUrl = "../Assets/Albums/" + albumid.AlbumImage;

            AlbumStockLBL.Text = "Album Stock: " + albumid.AlbumStock.ToString();
            AlbumDescLBL.Text = "Album Description: " + albumid.AlbumDescription;
            AlbumPriceLBL.Text = "Album Price: " + albumid.AlbumPrice.ToString();



            if (Session["User"] == null && Session["Admin"] == null)
            {
                Button btnCart = Master.FindControl("CartBTN") as Button;
                Button btnTrsct = Master.FindControl("TransactionBTN") as Button;
                Button btnUpdt = Master.FindControl("UpdateProfileBTN") as Button;
                Button btnLogout = Master.FindControl("LogoutBTN") as Button;
                btnCart.Visible = false;
                btnTrsct.Visible = false;
                btnUpdt.Visible = false;
                btnLogout.Visible = false;

            }
            if (Session["User"] != null)
            {
                int userid = -1;
                userid = (int)Session["User"];
                UpdateAlbumBTN.Visible = false;
                DeleteAlbumBTN.Visible = false;
            }
            else if (Session["Admin"] != null)
            {
                int userid = -1;
                userid = (int)Session["Admin"];
                UpdateAlbumBTN.Visible = true;
                DeleteAlbumBTN.Visible = true;
                AddCartBTN.Visible = false;
                QuantityTXT.Visible = false;
                QuantityLBL.Visible = false;
            }

        }

        protected void AddCartBTN_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(QuantityTXT.Text.ToString());
            int id = Convert.ToInt32(Request.QueryString["AlbumID"]);
            int userid = -1;
            if (Session["User"] != null)
            {

                userid = (int)Session["User"];
            }
            else if (Session["Admin"] != null)
            {

                userid = (int)Session["Admin"];
            }
            
            bool tempBool = CC.CartControllerAdd(userid, id, quantity);
            if (tempBool)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else
            {
                Errlbl.Visible = true;
                Errlbl.Text = "Quantity is more than Available Stock!";
            }
            
            
        }

        protected void UpdateAlbumBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["AlbumID"]);
            Response.Redirect("~/Views/UpdateAlbum.aspx?AlbumID=" + id);
        }

        protected void DeleteAlbumBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["AlbumID"]);
            AC.deleteAlbumController(id);
            Response.Redirect("~/Views/HomePage.aspx");
        }

        
    }
}