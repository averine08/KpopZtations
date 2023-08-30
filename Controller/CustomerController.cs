using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CustomerController
    {
        public static string RegisterCustomer(string name, string email, string gender, string address, string password, bool isTerms)
        {
            bool isEmpty = email.Equals("");
            bool isContain = email.Contains("@") && email.Contains(".");
            bool isAtFirst = email.StartsWith("@");
            bool isAtLast = email.EndsWith("@");
            bool isDotFirst = email.StartsWith(".");
            bool isDotLast = email.EndsWith(".");
            bool isDotNextToAt = email.Contains("@.") || email.Contains(".@");

            bool isEmailValid = !isEmpty && isContain && !isAtFirst && !isAtLast && !isDotFirst && !isDotLast && !isDotNextToAt;

            if (name.Trim().Equals(""))
            {
                return "Name must be filled!";
            }

            if (!(5 <= name.Length && name.Length <= 50))
            {
                return "Name must be between 5 and 50 characters!";
            }

            if (!isEmailValid)
            {
                return "Email must be valid!";
            }

            if (gender.Equals(""))
            {
                return "Gender must be selected!";
            }

            if (address.Trim().Equals(""))
            {
                return "Address must be filled!";
            }

            if (!address.EndsWith("Street"))
            {
                return "Address must end with \"Street\" (case sensitive)!";
            }

            if (password.Trim().Equals(""))
            {
                return "Password must be filled!";
            }

            if (!(password.Any(Char.IsDigit) && password.Any(Char.IsLetter)))
            {
                return "Password must be alphanumeric!";
            }

            if (!isTerms)
            {
                return "You must agree to the terms and conditions!";
            }

            return CustomerHandler.RegisterCustomer(name, email, gender, address, password);
        }

        public static string LoginCustomer(string email, string password)
        {
            bool isEmpty = email.Trim().Equals("");
            bool isContain = email.Contains("@") && email.Contains(".");
            bool isAtFirst = email.StartsWith("@");
            bool isAtLast = email.EndsWith("@");
            bool isDotFirst = email.StartsWith(".");
            bool isDotLast = email.EndsWith(".");
            bool isDotNextToAt = email.Contains("@.") || email.Contains(".@");

            bool isEmailValid = !isEmpty && isContain && !isAtFirst && !isAtLast && !isDotFirst && !isDotLast && !isDotNextToAt;


            if (!isEmailValid)
            {
                return "Email must be valid!";
            }

            if (password.Trim().Equals(""))
            {
                return "Password must be filled!";
            }

            if (!(password.Any(Char.IsDigit) && password.Any(Char.IsLetter)))
            {
                return "Password must be alphanumeric!";
            }

            return CustomerHandler.LoginCustomer(email, password);
        }

        public static string UpdateCustomer(string name, string email, string gender, string address, string password, string storedEmail, int id)
        {
            bool isEmpty = email.Trim().Equals("");
            bool isContain = email.Contains("@") && email.Contains(".");
            bool isAtFirst = email.StartsWith("@");
            bool isAtLast = email.EndsWith("@");
            bool isDotFirst = email.StartsWith(".");
            bool isDotLast = email.EndsWith(".");
            bool isDotNextToAt = email.Contains("@.") || email.Contains(".@");
            bool emailChanged = false;

            bool isEmailValid = !isEmpty && isContain && !isAtFirst && !isAtLast && !isDotFirst && !isDotLast && !isDotNextToAt;

            if (name.Trim().Equals(""))
            {
                return "Name must be filled!";
            }

            if (!(5 <= name.Length && name.Length <= 50))
            {
                return "Name must be between 5 and 50 characters!";
            }

            if (!isEmailValid)
            {
                return "Email must be valid!";
            }

            if(email.CompareTo(storedEmail) != 0)
            {
                emailChanged = true;
            }

            if (gender.Equals(""))
            {
                return "Gender must be selected!";
            }

            if (address.Trim().Equals(""))
            {
                return "Address must be filled!";
            }

            if (!address.EndsWith("Street"))
            {
                return "Address must end with \"Street\" (case sensitive)!";
            }

            if (password.Trim().Equals(""))
            {
                return "Password must be filled!";
            }

            if (!(password.Any(Char.IsDigit) && password.Any(Char.IsLetter)))
            {
                return "Password must be alphanumeric!";
            }
            return CustomerHandler.UpdateCustomer(name, email, gender, address, password, emailChanged, id);
        }
    }
}