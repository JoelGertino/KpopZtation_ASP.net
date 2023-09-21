using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;

namespace ProjectLAB_KpopZtation.Repository
{
    public class LoginRepository
    {
        Database1Entities db = new Database1Entities();
        public Customer getUser(string email, string password)
        {
            Customer accTemp = db.Customers.Where(x => x.CustomerEmail == email && x.CustomerPassword == password).FirstOrDefault();
            return accTemp;
        }
        public Customer findCustomer(int id)
        {
            Customer User = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            return User;
        }
    }
}