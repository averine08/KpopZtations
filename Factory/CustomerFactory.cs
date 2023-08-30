using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CustomerFactory
    {
        public static Customer CreateCustomer(string name, string email, string gender, string address, string password)
        {
            return new Customer()
            {
                CustomerName = name,
                CustomerEmail = email,
                CustomerGender = gender,
                CustomerAddress = address,
                CustomerPassword = password,
                CustomerRole = "CST"
            };
        }
    }
}