using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Handler;
using System.IO;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Controller
{
    public class ArtistController
    {
        ArtistHandler AH = new ArtistHandler();
        public bool AddArtist(string name, string image, double fileSize)
        {
            if(AH.IsNameUnique(name) && validateImage(image) && fileSize <= 2)
            {
                AH.AddArtist(name, image);
                return true;
            }
            return false;
            
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
        public List<Artist> getAllArtist()
        {
            return AH.getAllArtist();
        }

        public Artist getID(int id)
        {
            return AH.getID(id);
        }
    }
}