using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;

namespace ProjectLAB_KpopZtation.Factory
{
    public class AlbumFactory
    {
        public static Album CreateAlbum(string albumName, string albumDesc, int albumPrice, int albumStock, string albumImage, int artistId)
        {
            return new Album
            {
                AlbumName = albumName,
                AlbumDescription = albumDesc,
                AlbumStock = albumStock,
                AlbumImage = albumImage,
                AlbumPrice = albumPrice,
                ArtistID = artistId
            };
        }
    }
}