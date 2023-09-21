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
    public partial class AddArtists : System.Web.UI.Page
    {
        ArtistController AC = new ArtistController();
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void SubmitBTN_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                HttpPostedFile file = FileUpload1.PostedFile;
                double fileSize = file.ContentLength / 1048576;
                string name = ArtistNameTXT.Text.ToString();
                FileUpload1.SaveAs(Server.MapPath("~") + "/Assets/Artists/" + FileUpload1.FileName);
                string imageName = FileUpload1.FileName;
                bool artistBool = AC.AddArtist(name, imageName,fileSize);
                if (artistBool)
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
                else
                {
                    ErrLbl.Text = "Invalid Data";
                }
                
            }
            else
            {
                ErrLbl.Text = "Invalid Data";
            }
        }

        protected void CancelBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}