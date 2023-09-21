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
    public partial class Template : System.Web.UI.MasterPage
    {
        LoginController LC = new LoginController();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            int id = 0;
            if (!IsPostBack)
            {
                if (Request.Cookies["user_cookie"] != null)
                {
                    int.TryParse(Request.Cookies["user_cookie"].Value, out id);
                    Customer User = LC.findCustomer(id);
                }
                if (Session["User"] != null)
                {
                    LoginBTN.Visible = false;
                    RegisterBTN.Visible = false;
                    LogoutBTN.Visible = true;
                }
                if (Session["Admin"] != null)
                {
                    LoginBTN.Visible = false;
                    RegisterBTN.Visible = false;
                    LogoutBTN.Visible = true;
                    CartBTN.Visible = false;
                }
            }
        }

        protected void LogoutBTN_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;

            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(1);
            }

            Response.Redirect("~/Views/Login.aspx");

        }

        protected void RegisterBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void LoginBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void CartBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Cart.aspx");
        }

        protected void TransactionBTN_Click(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                Response.Redirect("~/Views/TransactionReport.aspx");
            }
            else
            {
                Response.Redirect("~/Views/TransactionHistory.aspx");
            }
        }

        protected void UpdateProfileBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/UpdateProfile.aspx");
        }

        protected void HomeBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}