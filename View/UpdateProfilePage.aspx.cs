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
    public partial class UpdateProfilePage : System.Web.UI.Page
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
                    TxtPassword.Attributes.Add("value", cust.CustomerPassword);
                }
                if (IsPostBack)
                {
                    if (!(String.IsNullOrEmpty(TxtPassword.Text.Trim())))
                    {
                        TxtPassword.Attributes["value"] = TxtPassword.Text;
                    }

                }
                BtnProfileContainer.Visible = false;
                BtnContainer.Visible = true;
            }
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string gender = RBLGender.SelectedValue;
            string address = txtAddress.Text;
            string password = TxtPassword.Text;

            string error = CustomerController.UpdateCustomer(name, email, gender, address, password, storedEmail, cust.CustomerID);

            errMsg.Text = error;
            if (error.Equals("Profile Updated"))
            {
                errMsg.ForeColor = System.Drawing.Color.Green;
                BtnProfileContainer.Visible = true;
                BtnContainer.Visible = false;
            }
            else
            {
                errMsg.ForeColor = System.Drawing.Color.Red;
            }
            Session["user"] = cust;
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ViewProfile");
        }

        protected void BtnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ViewProfile");
        }

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

        //protected void btnDeleteAccount_Click(object sender, EventArgs e)
        //{
        //    CustomerRepository.DeleteCustomerById(cust.CustomerID);
        //    Response.Redirect("/Home");
        //}
    }
}