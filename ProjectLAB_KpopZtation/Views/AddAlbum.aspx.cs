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
    public partial class AddAlbum : System.Web.UI.Page
    {
        AlbumController ac = new AlbumController();
        ArtistController arc = new ArtistController();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            Artist artistId = arc.getID(id);

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
                string albumname, albumdesc, albumimage;
                int albumprice, albumstock;
                albumname = AlbumNameTXT.Text.ToString();
                albumdesc = AlbumDescTXT.Text.ToString();
                albumprice = Convert.ToInt32(AlbumPriceTXT.Text.ToString());
                albumstock = Convert.ToInt32(AlbumStockTXT.Text.ToString());
                albumimage = FileUpload1.FileName;
                HttpPostedFile file = FileUpload1.PostedFile;
                double fileSize = file.ContentLength / 1048576;

                int id = Convert.ToInt32(Request.QueryString["id"]);
                Artist artistId = arc.getID(id);
                
            
            
                bool tempBool = ac.AddAlbumControl(albumname, albumdesc, albumprice, albumstock, albumimage, artistId.ArtistID, fileSize);
                if (tempBool)
                {
                    FileUpload1.SaveAs(Server.MapPath("~") + "/Assets/Albums/" + FileUpload1.FileName);

                    Response.Redirect("~/Views/DetailArtist.aspx?id=" + id);
                }
                else
                {
                    ErrLbl.Text = "Invalid Input";
                }
            }


        }

        protected void CancelBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Response.Redirect("~/Views/DetailArtist.aspx?id=" + id);
        }
    }
}