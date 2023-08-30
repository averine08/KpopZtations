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
    public partial class TransactionDetailsPage : System.Web.UI.Page
    {
        public Customer cust = null;
        public TransactionHeader tran = null;
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

                if (!cust.CustomerRole.Equals("CST"))
                {
                    Response.Redirect("/Home");
                }
            }

            string id = Request.QueryString["ID"];

            if (id == null)
            {
                Response.Redirect("/Home");
            }
            else
            {
                tran = TransactionRepository.GetTransactionById(Convert.ToInt32(id));

                if (tran == null)
                {
                    Response.Redirect("/Home");
                }
            }
        }

        public void GetImageUrl(string imageUrl)
        {
            Image1.ImageUrl = "~/Assets/Albums/" + imageUrl;
        }
    }
}