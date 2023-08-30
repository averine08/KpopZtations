using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ViewProfilePage : System.Web.UI.Page
    {
        public Customer cust = null;
        public string storedEmail;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("/Home");
            }
            else
            {
                if (Session["user"] == null)
                {
                    var cookieId = Int32.Parse(Request.Cookies["user_cookie"].Value);
                    cust = CustomerRepository.GetCustomerById(cookieId);
                    Session["user"] = cust;
                }
                else
                {
                    cust = (Customer)Session["user"];
                }

                storedEmail = cust.CustomerEmail;
                if (!IsPostBack)
                {
                    txtName.Text = cust.CustomerName;
                    txtEmail.Text = cust.CustomerEmail;
                    RBLGender.SelectedValue = cust.CustomerGender;
                    txtAddress.Text = cust.CustomerAddress;
                    txtPassword.Attributes.Add("value", cust.CustomerPassword);

                    txtName.Enabled = txtEmail.Enabled = RBLGender.Enabled = txtAddress.Enabled = txtPassword.Enabled = false;
                }
            }
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UpdateProfile");
        }

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("/DeleteAccount");
        }
    }
}