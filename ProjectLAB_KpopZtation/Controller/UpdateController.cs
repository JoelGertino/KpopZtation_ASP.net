using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Handler;
using ProjectLAB_KpopZtation.Model;


namespace ProjectLAB_KpopZtation.Controller
{
    public class UpdateController
    {
        UpdateHandler UH = new UpdateHandler();
        ArtistHandler AH = new ArtistHandler();

        public int UpdateArtistsController(int id, string name, string image)
        {
            if (AH.getID(id) != null)
            {
                if (name.Length != 0 && image.Length != 0)
                {
                    if (AH.IsNameUnique(name) && AH.IsNameUnique(image))
                    {
                        UH.UpdateArtistHandler(id, name, image);
                        return 1;
                    }
                }
            }
            return 0;
        }
        public void DeleteArtistController(int id)
        {
            UH.DeleteArtistHandler(id);
        }

    }
}