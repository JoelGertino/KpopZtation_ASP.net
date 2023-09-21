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
    public partial class UpdateArtistsaspx : System.Web.UI.Page
    {
        AlbumController AC = new AlbumController();
        UpdateController UC = new UpdateController();
        ArtistController arc = new ArtistController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Artist artistId = arc.getID(id);
            ItemLbl.Text = artistId.ArtistName;
            ItemImage.ImageUrl = "../Assets/Artists/" + artistId.ArtistImage;

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
            if (Session["Admin"] != null)
            {
                EditBtn.Visible = true;
                CancelBtn.Visible = true;
            }
        }



        protected void EditBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            string name = ArtistNameTXT.Text.ToString();
            string image = FileUpload1.FileName;
            int tempBool = UC.UpdateArtistsController(id, name, image);
            if (tempBool == 1)
            {
                FileUpload1.SaveAs(Server.MapPath("~") + "/Assets/Artists/" + FileUpload1.FileName);
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else if (tempBool == 0)
            {
                ErrLbl.Text = "Invalid Input";
            }
        }

        protected void CancelBtn_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}