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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        public static List<TransactionHeader> transactionList = null;
        public List<TransactionDetail> transactionDetailsList = null;
        public Customer cust = null;
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
                    var id = Int32.Parse(Request.Cookies["user_cookie"].Value);
                    cust = CustomerRepository.GetCustomerById(id);
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

            int custId = cust.CustomerID;
            transactionList = TransactionRepository.GetTransactionByCustId(custId);
        }

        public void GetImageUrl(string imageUrl)
        {
            Image1.ImageUrl = "~/Assets/Albums/" + imageUrl;
        }
    }
}