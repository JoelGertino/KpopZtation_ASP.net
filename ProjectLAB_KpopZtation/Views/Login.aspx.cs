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
    public partial class Login : System.Web.UI.Page
    {
        LoginController LC = new LoginController();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["user_cookie"] != null)
            {
                if (Session["User"] != null || Session["Admin"] != null)
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
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

        protected void LoginBtnn_Click(object sender, EventArgs e)
        {
            string email, password;
            email = EmailTxt.Text.ToString();
            password = PasswordTxt.Text.ToString();
            bool remember = RmbrMeBox.Checked;

            Customer CustomerBool = LC.LoginValidation(email, password);
            if (CustomerBool != null)
            {
                int tempBool = LC.roleValidation(CustomerBool);

                if (tempBool == 1)
                {
                    Button btnCart = Master.FindControl("CartBTN") as Button;
                    Button btnTrsct = Master.FindControl("TransactionBTN") as Button;
                    Button btnUpdt = Master.FindControl("UpdateProfileBTN") as Button;
                    Button btnLogout = Master.FindControl("LogoutBTN") as Button;
                    if (remember)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = CustomerBool.CustomerID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    Session["Admin"] = CustomerBool.CustomerID;
                    btnTrsct.Visible = true;
                    btnUpdt.Visible = true;
                    btnLogout.Visible = true;
                    btnCart.Visible = false;
                    Response.Redirect("~/Views/HomePage.aspx");


                }
                else if (tempBool == 2)
                {
                    Button btnCart = Master.FindControl("CartBTN") as Button;
                    Button btnTrsct = Master.FindControl("TransactionBTN") as Button;
                    Button btnUpdt = Master.FindControl("UpdateProfileBTN") as Button;
                    Button btnLogout = Master.FindControl("LogoutBTN") as Button;
                    if (remember)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = CustomerBool.CustomerID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    btnTrsct.Visible = true;
                    btnUpdt.Visible = true;
                    btnLogout.Visible = true;
                    btnCart.Visible = true;
                    Session["User"] = CustomerBool.CustomerID;

                    Response.Redirect("~/Views/HomePage.aspx");
                }

            }
            else
            {
                ErrorLbl.Text = "Invalid Data";
            }
        }

        protected void RegisterBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }
    }
}