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
    
    public partial class HomePage : System.Web.UI.Page
    {
        
        UpdateController UC = new UpdateController();
        ArtistController AC = new ArtistController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CardRepeater.DataSource = AC.getAllArtist();
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
                }

                if (Session["Admin"] != null)
                {
                    AddArtistBtn.Visible = true;
                    foreach (RepeaterItem item in CardRepeater.Items)
                    {
                        if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                        {
                            LinkButton UpdateButton = (LinkButton)item.FindControl("UpdateButton");
                            LinkButton DeleteButton = (LinkButton)item.FindControl("DeleteButton");
                            UpdateButton.Visible = true;
                            DeleteButton.Visible = true;
                        }
                    }


                }
            }
        }


        protected void OpenDetail_Click(object sender, EventArgs e)
        {
            LinkButton linkbtn = (LinkButton)sender;
            string id = linkbtn.CommandArgument;
            Response.Redirect("~/Views/DetailArtist.aspx?id=" + id);
        }

        protected void AddArtistBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/AddArtists.aspx");
        }

        

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            LinkButton updateButton = (LinkButton)sender;
            string id = updateButton.CommandArgument;
            Response.Redirect("~/Views/UpdateArtists.aspx?id=" + id);
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            LinkButton deleteButton = (LinkButton)sender;
            string idTemp = deleteButton.CommandArgument;
            int id = Convert.ToInt32(idTemp);
            UC.DeleteArtistController(id);
            Response.Redirect("~/Views/HomePage.aspx");
        }

       
    }
}