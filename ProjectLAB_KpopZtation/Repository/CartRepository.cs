using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Factory;
namespace ProjectLAB_KpopZtation.Repository
{
    public class CartRepository
    {
        Database1Entities db = new Database1Entities();

        public void createCartItem(int customerID, int AlbumID, int quantity)
        {
            db.Carts.Add(CartFactory.CreateCartItem(customerID, AlbumID, quantity));
            db.SaveChanges();
        }

        public int getStock(int id)
        {
            Album tempAlbum = db.Albums.Find(id);
            int stock = tempAlbum.AlbumStock;
            return stock;

        }
        public List<object> GetAlbumDetailsByCustomerId(int custId)
        {
            var albumDetails = (from album in db.Albums
                                join cart in db.Carts on album.AlbumID equals cart.AlbumID
                                where cart.CustomerID == custId
                                select new
                                {
                                    album.AlbumName,
                                    AlbumImage = album.AlbumImage,
                                    Quantity = cart.Qty,
                                    album.AlbumPrice
                                }).ToList<object>();
            return albumDetails;
        }
        public List<Cart> Carts(int userid)
        {
            return db.Carts.Where(x => x.CustomerID == userid).ToList();
        }
        public void DeleteCart(int userid)
        {
            db.Carts.RemoveRange(db.Carts.Where(x => x.CustomerID == userid));
            db.SaveChanges();
        }

        public void UpdateCart(int customerID, int albumId, int quantity)
        {
            Cart tempCart = db.Carts.Where(x => x.AlbumID == albumId).FirstOrDefault();
            if(tempCart != null)
            {
                tempCart.Qty = tempCart.Qty + quantity;
                db.SaveChanges();
            }
            else
            {
                createCartItem(customerID, albumId, quantity);
            }
            
        }
        public void updateStock(int albumId, int quantity)
        {
            Album tempAlbum = db.Albums.Where(x => x.AlbumID == albumId).FirstOrDefault();
            tempAlbum.AlbumStock = tempAlbum.AlbumStock - quantity;
        }
    }
}