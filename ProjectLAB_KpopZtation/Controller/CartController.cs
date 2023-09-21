using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Handler;
namespace ProjectLAB_KpopZtation.Controller
{
    public class CartController
    {
        CartHandler CH = new CartHandler();

        public bool CartControllerAdd(int customerID, int albumID, int quantity)
        {
            int stock = CH.stockHand(albumID);
            if (stock >= quantity)
            {
                CH.CartHand(customerID, albumID, quantity);
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Cart> Carts(int userid)
        {
            return CH.Carts(userid);
        }
        public void DeleteCart(int userid)
        {
            CH.DeleteCart(userid);
        }
        public void updateStock(int albumId, int quantity)
        {
            CH.updateStock(albumId, quantity);
        }

        public List<object> GetAlbumDetailsByCustomerId(int custId)
        {
            return CH.GetAlbumDetailsByCustomerId(custId);
        }
    }
}