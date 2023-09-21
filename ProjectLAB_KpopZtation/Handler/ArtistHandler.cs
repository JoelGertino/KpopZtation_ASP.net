using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Repository;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Handler
{
    public class ArtistHandler
    {
        ItemRepository IR = new ItemRepository();
        public void AddArtist(string name, string image)
        {
            IR.AddArtist(name, image);
        }
        public bool IsNameUnique(string name)
        {
            return IR.IsNameUnique(name);
        }
        public Artist getID(int id)
        {
            return IR.getID(id);
        }
        public List<Artist> getAllArtist()
        {
            return IR.getAllArtist();
        }

        
    }

  
}