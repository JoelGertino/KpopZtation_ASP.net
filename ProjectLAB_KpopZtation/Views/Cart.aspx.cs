using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLAB_KpopZtation.Controller;
namespace ProjectLAB_KpopZtation.Views
{
    public partial class Cart : System.Web.UI.Page
    {
		CartController CC = new CartController();
		TransactionController TC = new TransactionController();
		protected void Page_Load(object sender, EventArgs e)
		{
			int userid = -1;
			if (Session["User"] != null)
			{
				userid = (int)Session["User"];
			}
			CardRepeater.DataSource = CC.GetAlbumDetailsByCustomerId(userid);
			CardRepeater.DataBind();
		}
		protected void CheckoutBtn_Click(object sender, EventArgs e)
		{
			int userid = (int)Session["User"];

			List<Model.Cart> transactions = CC.Carts(userid);
			int headerID = TransactionController.InsertTransaction(userid);


			foreach (Model.Cart cart in transactions)
			{
				TC.CreateTransactionDetail(headerID, cart.AlbumID, cart.Qty);
				CC.updateStock(cart.AlbumID, cart.Qty);
			}
			
			CC.DeleteCart(userid);
			Response.Redirect("~/Views/TransactionHistory.aspx");
		}
	}
}