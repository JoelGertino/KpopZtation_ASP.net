using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Handler;
namespace ProjectLAB_KpopZtation.Controller
{
    public class RegisterController
    {
        
        RegisterHandler RH = new RegisterHandler();
        
        public int RegisterValidation(string name, string email, string password, string gender, string address)
        {
            if (name.Length > 5 && name.Length < 50)
            {
                if (!(string.IsNullOrEmpty(email)) && RH.EmailHand(email))
                {
                    if (!string.IsNullOrEmpty(gender))
                    {
                        if (address.EndsWith("Street") && !string.IsNullOrEmpty(address))
                        {
                            if (IsAlphaNumeric(password))
                            {

                                RH.RegisterHand(name, password, address, email, gender);
                                return 1;

                            }
                        }
                    }
                }
            }
            return 0;

        }

        public bool IsAlphaNumeric(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public Customer getCustomer(int id)
        {
            return RH.getCustomer(id);
        }

        public bool updateProfileName(int id, string name)
        {
            if (name.Length > 5 && name.Length < 50)
            {
                RH.updateName(id, name);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateProfileEmail(int id, string email)
        {
            if (!(string.IsNullOrEmpty(email)) && RH.EmailHand(email))
            {
                RH.updateEmail(id, email);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateProfileGender(int id, string gender)
        {
            if (!string.IsNullOrEmpty(gender))
            {
                RH.UpdateGender(id, gender);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateProfileAddress(int id, string address)
        {
            if (address.EndsWith("Street") && !string.IsNullOrEmpty(address))
            {
                RH.updateAddress(id, address);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateProfilePassword(int id, string password)
        {
            if (IsAlphaNumeric(password))
            {
                RH.updatePassword(id, password);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}