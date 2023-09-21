using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Repository;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Handler
{
    public class RegisterHandler
    {
        RegisterRepository RR = new RegisterRepository();
        
        public void RegisterHand(string name, string password, string address, string email, string gender)
        {
            RR.addCustomer(name, password, email, address, gender);
        }

        public bool EmailHand(string email)
        {
            return RR.findEmail(email);
        }

        public Customer getCustomer(int id)
        {
            return RR.getCustomer(id);
        }

        public void updateName(int id, string name)
        {
            RR.updateName(id, name);
        }

        public void updateEmail(int id, string email)
        {
            RR.updateEmail(id, email);
        }

        public void UpdateGender(int id, string gender)
        {
            RR.UpdateGender(id, gender);
        }

        public void updateAddress(int id, string address)
        {
            RR.updateAddress(id, address);
        }

        public void updatePassword(int id, string password)
        {
            RR.updatePassword(id, password);
        }

    }


}