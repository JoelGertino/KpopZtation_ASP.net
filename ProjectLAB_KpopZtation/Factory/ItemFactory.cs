using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Factory
{
    public class ItemFactory
    {
        public static Artist createArtist(string name, string image)
        {
            return new Artist
            {
                ArtistName = name,
                ArtistImage = image
            };
        }
    }
}