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
    
        public partial class DetailArtist : System.Web.UI.Page
        {
            ArtistController arc = new ArtistController();
            AlbumController AC = new AlbumController();
            UpdateController UC = new UpdateController();
            protected void Page_Load(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                Artist artistId = arc.getID(id);
                ItemLbl.Text = artistId.ArtistName;
                ItemImage.ImageUrl = "../Assets/Artists/" + artistId.ArtistImage;

                CardRepeater.DataSource = AC.GetAllAlbumsController(artistId.ArtistID);
                CardRepeater.DataBind();

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
                    foreach (RepeaterItem item in CardRepeater.Items)
                    {
                        LinkButton AlbumDetail = item.FindControl("AlbumDetail") as LinkButton;
                        AlbumDetail.Enabled = false;
                        AlbumDetail.Attributes["style"] = "cursor: not-allowed; pointer-events: none;";
                    }


            }
                if (Session["Admin"] != null)
                {
                    BtnPanel.Visible = true;
                    AddAlbumBtn.Visible = true;
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
            protected void CancelBtn_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
            protected void DeleteBtn_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                UC.DeleteArtistController(id);
                Response.Redirect("~/Views/HomePage.aspx");
            }




            protected void AlbumDetail_Click(object sender, EventArgs e)
            {
                LinkButton linkbtn = (LinkButton)sender;
                string id = linkbtn.CommandArgument;

                Response.Redirect("~/Views/DetailAlbum.aspx?AlbumID=" + id);
            }



            protected void OpenDetail_Click(object sender, EventArgs e)
            {

            }

            protected void AddAlbumBtn_Click1(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);

                Response.Redirect("~/Views/AddAlbum.aspx?id=" + id);
            }

            protected void UpdateBtn_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                Response.Redirect("~/Views/UpdateArtists.aspx?id=" + id);
            }
        }
}