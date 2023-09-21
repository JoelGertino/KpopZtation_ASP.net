using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Repository;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Handler
{
    public class CartHandler
    {
        CartRepository CR = new CartRepository();

        public void CartHand(int customerID, int albumID, int quantity)
        {
            CR.UpdateCart(customerID, albumID, quantity);
        }
        public int stockHand(int id)
        {
            return CR.getStock(id);
        }
        public List<Cart> Carts(int userid)
        {
            return CR.Carts(userid);
        }
        public void DeleteCart(int userid)
        {
            CR.DeleteCart(userid);
        }
        public void updateStock(int albumId, int quantity)
        {
             CR.updateStock(albumId, quantity);
        }

        public List<object> GetAlbumDetailsByCustomerId(int custId)
        {
            return CR.GetAlbumDetailsByCustomerId(custId);
        }
    }
}