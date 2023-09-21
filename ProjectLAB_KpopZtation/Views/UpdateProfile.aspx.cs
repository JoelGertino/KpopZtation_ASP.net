using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Controller;
namespace ProjectLAB_KpopZtation.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
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
            int userid=-1;
            
            
            if (Session["User"] != null)
            {
                userid = (int)Session["User"];
            } else if (Session["Admin"] != null)
            {
                userid = (int)Session["Admin"];
            }
            

            Customer tempCust = RC.getCustomer(userid);
            
            NameLBL.Text = "Customer Name :  " + tempCust.CustomerName;
            EmailLBL.Text = "Customer Email :  " + tempCust.CustomerEmail;
            GenderLBL.Text = "Customer Gender :  " + tempCust.CustomerGender;
            AddressLBL.Text = "Customer Address :  " + tempCust.CustomerAddress;
            PasswordLBL.Text = "Customer Password :  " + tempCust.CustomerPassword;
            
        }

       
        protected void GenderRadio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void NameButton_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text.ToString();
            int id = 0;
            if (Session["User"] != null)
            {
                id = (int)Session["User"];
            }
            else if (Session["Admin"] != null)
            {
                id = (int)Session["Admin"];
            }
            bool tempBool = RC.updateProfileName(id, name);
            if (tempBool)
            {
                Response.Redirect("~/Views/UpdateProfile.aspx");
            }
            else
            {
                ErrNameLbl.Text = "Must be filled and between 5 and 50 characters";
            }
            
        }


        protected void EmailButton_Click(object sender, EventArgs e)
        {
            string email = EmailTXT.Text.ToString();
            int id = 0;
            if (Session["User"] != null)
            {
                id = (int)Session["User"];
            }
            else if (Session["Admin"] != null)
            {
                id = (int)Session["Admin"];
            }
            bool tempBool = RC.updateProfileEmail(id, email);
            if (tempBool)
            {
                Response.Redirect("~/Views/UpdateProfile.aspx");
            }
            else
            {
                ErrEmailLbl.Text = "Must be filled and unique among the customer’s email";
            }
        }

        protected void GenderButton_Click(object sender, EventArgs e)
        {
            string gender = GenderRadio.SelectedValue;
            int id = 0;
            if (Session["User"] != null)
            {
                id = (int)Session["User"];
            }
            else if (Session["Admin"] != null)
            {
                id = (int)Session["Admin"];
            }
            bool tempBool = RC.updateProfileGender(id, gender);
            if (tempBool)
            {
                Response.Redirect("~/Views/UpdateProfile.aspx");
            }
            else
            {
                ErrGenderLbl.Text = "Must be selected";
            }
        }

        protected void AddressButton_Click(object sender, EventArgs e)
        {
            string address = AddressTXT.Text.ToString();
            int id = 0;
            if (Session["User"] != null)
            {
                id = (int)Session["User"];
            }
            else if (Session["Admin"] != null)
            {
                id = (int)Session["Admin"];
            }
            bool tempBool = RC.updateProfileAddress(id, address);
            if (tempBool)
            {
                Response.Redirect("~/Views/UpdateProfile.aspx");
            }
            else
            {
                ErrAddressLbl.Text = "Must be filled and ends with ‘Street’";
            }
        }

        protected void PasswordButton_Click(object sender, EventArgs e)
        {
            string password = PasswordTXT.Text.ToString();
            int id = 0;
            if (Session["User"] != null)
            {
                id = (int)Session["User"];
            }
            else if (Session["Admin"] != null)
            {
                id = (int)Session["Admin"];
            }
            bool tempBool = RC.updateProfilePassword(id, password);
            if (tempBool)
            {
                Response.Redirect("~/Views/UpdateProfile.aspx");
            }
            else
            {
                ErrPasswordLbl.Text = "Must be filled and alphanumeric";
            }
        }

    }
}