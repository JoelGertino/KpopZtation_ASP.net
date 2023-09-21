using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;

namespace ProjectLAB_KpopZtation.Factory
{
    public class RegisterFactory
    {
        public Customer createUser(string name, string password, string email, string address, string gender, string role)
        {
            return new Customer
            {
                CustomerName = name,
                CustomerPassword = password,
                CustomerEmail = email,
                CustomerAddress = address,
                CustomerGender = gender,
                CustomerRole = role
            };
        }
    }
}