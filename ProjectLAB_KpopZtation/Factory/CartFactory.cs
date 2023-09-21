using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;

namespace ProjectLAB_KpopZtation.Factory
{
    public class CartFactory
    {
        public static Cart CreateCartItem(int customerID, int albumID, int quantity)
        {
            return new Cart
            {
                CustomerID = customerID,
                AlbumID = albumID,
                Qty = quantity
            };
        }
    }
}