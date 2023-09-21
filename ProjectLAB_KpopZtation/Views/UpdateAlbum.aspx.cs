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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        AlbumController AC = new AlbumController();
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
            
        }

        protected void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                int id = Convert.ToInt32(Request.QueryString["AlbumID"]);
                string name, description, image;
                int price, stock;
                HttpPostedFile file = FileUpload1.PostedFile;
                double fileSize = file.ContentLength / 1048576;
                name = AlbumNameTxt.Text.ToString();
                description = AlbumDescTxt.Text.ToString();
                image = FileUpload1.FileName;
                price = Convert.ToInt32(AlbumPriceTxt.Text.ToString());
                stock = Convert.ToInt32(AlbumStockTxt.Text.ToString());
                bool TempBool = AC.UpdateAlbumController(id, name, description, price, stock, image, fileSize);

                if (TempBool)
                {
                    FileUpload1.SaveAs(Server.MapPath("~") + "/Assets/Albums/" + FileUpload1.FileName);
                    Response.Redirect("~/Views/HomePage.aspx");
                }
                else
                {
                    Errlbl.Text = "Invalid Data";
                }
            }
        }

        protected void CancelBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}