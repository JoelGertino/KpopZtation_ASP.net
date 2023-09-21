using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Repository;
namespace ProjectLAB_KpopZtation.Handler
{
    public class LoginHandler
    {
        LoginRepository LR = new LoginRepository();
        public Customer loginHand(string email, string password)
        {
            return LR.getUser(email, password);
        }
        public Customer findCustomer(int id)
        {
            return LR.findCustomer(id);
        }
    }
}