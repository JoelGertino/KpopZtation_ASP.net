using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLAB_KpopZtation.Controller;

namespace ProjectLAB_KpopZtation.Views
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        TransactionController TC = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userid = (int)Session["User"];

            TableRepeater.DataSource = TC.GetAllTransaction(userid);
            TableRepeater.DataBind();
        }
    }
}