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
    public partial class Register : System.Web.UI.Page
    {
        RegisterController RC = new RegisterController();
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

        protected void GenderRadioList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LoginBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void RegisterBTN_Click(object sender, EventArgs e)
        {
            String name, email, password, gender, address;
            name = NameTxt.Text.ToString();
            email = EmailTXT.Text.ToString();
            password = PasswordTXT.Text.ToString();
            gender = GenderRadioList.SelectedValue;
            address = AddressTXT.Text.ToString();


            int tempBool = RC.RegisterValidation(name, email, password, gender, address);

            if (tempBool == 1)
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                ErrorLBL.Text = "Invalid Data";
            }
        }

        
    }
}