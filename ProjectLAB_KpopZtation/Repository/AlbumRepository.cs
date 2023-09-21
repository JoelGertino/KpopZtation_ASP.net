using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Factory;

namespace ProjectLAB_KpopZtation.Repository
{
    public class AlbumRepository
    {
        Database1Entities db = new Database1Entities();
        public void AddAlbum(string AlbumName, string AlbumDesc, int AlbumPrice, int AlbumStock, string AlbumImage, int ArtistID)
        {
            db.Albums.Add(AlbumFactory.CreateAlbum(AlbumName, AlbumDesc, AlbumPrice, AlbumStock, AlbumImage, ArtistID));
            db.SaveChanges();
        }
        public List<Album> GetAllAlbums(int artistId)
        {
            List<Album> albums = (from Album in db.Albums where Album.ArtistID == artistId select Album).ToList();
            return albums;

        }

        public Album getAlbumID(int id)
        {
            return db.Albums.Where(x => x.AlbumID == id).FirstOrDefault();
        }
        public void updateAlbum(int id, string name, string Desc, int stock, int price, string image)
        {
            Album tempID = db.Albums.Find(id);
            tempID.AlbumName = name;
            tempID.AlbumDescription = Desc;
            tempID.AlbumStock = stock;
            tempID.AlbumPrice = price;
            tempID.AlbumImage = image;
            db.SaveChanges();

        }
        public void deleteAlbum(int id)
        {
            db.Albums.Remove(db.Albums.Find(id));
            db.SaveChanges();
        }
    }
}