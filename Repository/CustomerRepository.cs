using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        private static KpopZtationDBEntities db = DatabaseSingleton.GetInstance();

        public static string AddCustomer(string name, string email, string gender, string address, string password)
        {
            Customer newCustomer = CustomerFactory.CreateCustomer(name, email, gender, address, password);
            db.Customers.Add(newCustomer);
            db.SaveChanges();

            return "";
        }
        public static Customer GetCustomerByEmail(string email)
        {
            return (from cust in db.Customers where cust.CustomerEmail.Equals(email) select cust).FirstOrDefault();
        }

        public static Customer GetCustomerById(int id)
        {
            return (from x in db.Customers where x.CustomerID == id select x).FirstOrDefault();
        }

        public static Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            return (from cust in db.Customers where cust.CustomerEmail.Equals(email) && cust.CustomerPassword.Equals(password) select cust).FirstOrDefault();
        }

        public static void DeleteCustomerById(int id)
        {
            Customer customer = GetCustomerById(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        public static string UpdateCustomer(string name, string email, string gender, string address, string password, int id)
        {
            Customer customer = GetCustomerById(id);
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerGender = gender;
            customer.CustomerAddress = address;
            customer.CustomerPassword = password;
            db.SaveChanges();

            return "Profile Updated";
        }
    }
}