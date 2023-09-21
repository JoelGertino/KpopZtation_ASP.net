using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Factory;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Repository
{
    public class RegisterRepository
    {
        RegisterFactory RF = new RegisterFactory();
        Database1Entities db = new Database1Entities();

        public void addCustomer(string name, string password, string email, string address, string gender)
        {
            Customer newUser = RF.createUser(name, password, email, address, gender, "Cust");
            db.Customers.Add(newUser);
            db.SaveChanges();
        }

        public bool findEmail(string email)
        {
            Customer emailtemp = db.Customers.Where(x => x.CustomerEmail == email).FirstOrDefault();
            if (emailtemp != null)
            {
                return false;
            }
            return true;
        }

        public Customer getCustomer(int id)
        {
            Customer user = db.Customers.Find(id);
            return user;
        }

        public void updateName(int id, string name)
        {
            Customer user = db.Customers.Find(id);
            user.CustomerName = name;
            db.SaveChanges();
        }

        public void updateEmail(int id, string email)
        {
            Customer user = db.Customers.Find(id);
            user.CustomerEmail = email;
            db.SaveChanges();
        }

        public void UpdateGender(int id, string gender)
        {
            Customer user = db.Customers.Find(id);
            user.CustomerGender = gender;
            db.SaveChanges();
        }

        public void updateAddress(int id, string address)
        {
            Customer user = db.Customers.Find(id);
            user.CustomerAddress = address;
            db.SaveChanges();
        }

        public void updatePassword(int id, string password)
        {
            Customer user = db.Customers.Find(id);
            user.CustomerPassword = password;
            db.SaveChanges();
        }
    }
}