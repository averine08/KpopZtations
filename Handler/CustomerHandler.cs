using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CustomerHandler
    {
        public static string RegisterCustomer(string name, string email, string gender, string address, string password)
        {
            if (CustomerRepository.GetCustomerByEmail(email) != null)
            {
                return "Email must be unique!";
            }

            return CustomerRepository.AddCustomer(name, email, gender, address, password);
        }

        public static string UpdateCustomer(string name, string email, string gender, string address, string password, bool emailChanged, int id)
        {
            if (CustomerRepository.GetCustomerByEmail(email) != null && emailChanged == true)
            {
                return "Email must be unique!";
            }

            return CustomerRepository.UpdateCustomer(name, email, gender, address, password, id);
        }

        public static string LoginCustomer(string email, string password)
        {
            if (CustomerRepository.GetCustomerByEmail(email) == null)
            {
                return "Email not found";
            }
            else
            {
                if (CustomerRepository.GetCustomerByEmailAndPassword(email, password) == null)
                {
                    return "Incorrect password!";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}