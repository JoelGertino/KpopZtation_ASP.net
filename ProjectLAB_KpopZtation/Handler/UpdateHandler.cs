using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Repository;
namespace ProjectLAB_KpopZtation.Handler
{
    public class UpdateHandler
    {
        ItemRepository IR = new ItemRepository();

        public void UpdateArtistHandler(int id, string name, string image)
        {
            IR.updateItem(id, name, image);
        }
        public void DeleteArtistHandler(int id)
        {
            IR.deleteItem(id);
        }

    }
}