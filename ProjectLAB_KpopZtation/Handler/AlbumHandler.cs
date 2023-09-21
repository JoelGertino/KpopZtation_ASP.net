using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Repository;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Handler
{
    public class AlbumHandler
    {
        AlbumRepository ar = new AlbumRepository();

        public void AddAlbumHand(string albumName, string albumDesc, int albumPrice, int albumStock, string albumImage, int artistId)
        {
            ar.AddAlbum(albumName, albumDesc, albumPrice, albumStock, albumImage, artistId);
        }
        public List<Album> GetAllAlbumsHand(int artistID)
        {
            List<Album> albums = ar.GetAllAlbums(artistID);
            return albums;

        }

        public void UpdateAlbumHandler(int id, string name, string desc, int price, int stock, string image)
        {
            ar.updateAlbum(id, name, desc, stock, price, image);
        }
        public void deleteAlbumHand(int id)
        {
            ar.deleteAlbum(id);
        }

        public Album getAlbumID(int id)
        {
            return ar.getAlbumID(id);
        }

    }
}