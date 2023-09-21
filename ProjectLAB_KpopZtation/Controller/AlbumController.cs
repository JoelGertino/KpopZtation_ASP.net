using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Handler;
using ProjectLAB_KpopZtation.Model;
using System.IO;
namespace ProjectLAB_KpopZtation.Controller
{
    public class AlbumController
    {
        AlbumHandler ah = new AlbumHandler();

        public List<Album> GetAllAlbumsController(int artistID)
        {
            List<Album> albums = ah.GetAllAlbumsHand(artistID);
            return albums;

        }
        public bool AddAlbumControl(string albumName, string albumDesc, int albumPrice, int albumStock, string albumImage, int artistId, double fileSize)
        {
            if (albumName.Length > 0 && albumName.Length < 50)
            {
                if (albumDesc.Length > 0 && albumDesc.Length < 255)
                {
                    if (albumPrice > 100000 && albumPrice < 1000000)
                    {
                        if (albumStock > 0)
                        {
                            if (validateImage(albumImage) && fileSize <= 2)
                            {
                                 ah.AddAlbumHand(albumName, albumDesc, albumPrice, albumStock, albumImage, artistId);
                                 return true;
                            }
                               
                        }
                    }
                }
            }
            return false;
        }

        public bool UpdateAlbumController(int id, string albumName, string albumDesc, int albumPrice, int albumStock, string albumImage, double fileSize)
        {
            if (albumName.Length > 0 && albumName.Length < 50)
            {
                if (albumDesc.Length > 0 && albumDesc.Length < 255)
                {
                    if (albumPrice > 100000 && albumPrice < 1000000)
                    {
                        if (albumStock > 0)
                        {
                            if (validateImage(albumImage) && fileSize <=2)
                            {
                                ah.UpdateAlbumHandler(id, albumName, albumDesc, albumPrice, albumStock, albumImage);
                                return true;
                            }
                            
                        }
                    }
                }
            }
            return false;
        }
        public void deleteAlbumController(int id)
        {
            ah.deleteAlbumHand(id);
        }
        public bool validateImage(string imageFile)
        {
           
            string fileExtension = Path.GetExtension(imageFile).ToLower();
            string[] extension = { ".png", ".jpg", ".jpeg", ".jfif" };

            if (!extension.Contains(fileExtension))
            {
                return false;
            }
            return true;
        }

        public Album getAlbumID(int id)
        {
            return ah.getAlbumID(id);
        }
    }
}