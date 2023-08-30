using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (!(String.IsNullOrEmpty(TxtPassword.Text.Trim())))
                {
                    TxtPassword.Attributes["value"] = TxtPassword.Text;
                }
 
            }

            if (!IsPostBack)
            {
                TxtPassword.Attributes.Add("value", TxtPassword.Text);
            }

            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("/Home");
            }

        }

        // NOTE: Submit hanya bisa kalau tekan tombol, jangan tekan ENTER
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            String email = TxtEmail.Text;
            String password = TxtPassword.Text;
            bool isRemember = CBRemember.Checked;
            //Debug.WriteLine("Email : " + email);
            //Debug.WriteLine("Password " + password);
            string error = CustomerController.LoginCustomer(email, password);

            if (error.Equals(""))
            {
                Customer cust = CustomerRepository.GetCustomerByEmailAndPassword(email, password);

                Session["user"] = cust;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie")
                    {
                        Value = cust.CustomerID.ToString(),
                        Expires = DateTime.Now.AddHours(4)
                    };
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("/Home");
            }
            else
            {
                LblError.Text = error;
            }
        }

        // Ceritanya mau bikin see and hide password, tapi tiap pencet malah ke refresh yang bikin value hilang 
        protected void btnSeePassword_Click(object sender, EventArgs e)
        {


            if (TxtPassword.TextMode == TextBoxMode.Password)
            {
                
                TxtPassword.TextMode = TextBoxMode.SingleLine;
                TxtPassword.Text = TxtPassword.Attributes["value"];
                btnSeePassword.Text = "hide password";

            }
            else if (TxtPassword.TextMode == TextBoxMode.SingleLine)
            {
                TxtPassword.TextMode = TextBoxMode.Password;
                TxtPassword.Text = TxtPassword.Attributes["value"];
                btnSeePassword.Text = "see password";
            }
            

        }
    }
}