using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Factory;
namespace ProjectLAB_KpopZtation.Repository
{
    public class ItemRepository
    {
        Database1Entities db = new Database1Entities();
        

        public void AddArtist(string name, string image)
        {
            db.Artists.Add(ItemFactory.createArtist(name, image));
            db.SaveChanges();
        }

        public Artist getID(int id)
        {
            return db.Artists.Where(x => x.ArtistID == id).FirstOrDefault();
        }

        public void deleteItem(int id)
        {
            db.Artists.Remove(db.Artists.Find(id));
            db.SaveChanges();
        }

        public void updateItem(int id, string name, string image)
        {
            Artist tempID = db.Artists.Find(id);
            tempID.ArtistName = name;
            tempID.ArtistImage = image;
            db.SaveChanges();

        }
        public List<Artist> getAllArtist()
        {
            return (from Artist in db.Artists select Artist).ToList();
        }
        public bool IsNameUnique(string name)
        {
            List<Artist> artists = getAllArtist();
            foreach (var artist in artists)
            {
                if (artist.ArtistName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            return true;
        }

    }
}