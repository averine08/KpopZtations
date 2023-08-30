using KpopZtation.Handler;
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
    public partial class CartPage : System.Web.UI.Page
    {
        public List<Cart> listCart = new List<Cart>();
        public int customerID;
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

            if (cust == null)
            {
                Response.Redirect("/Home");
            }

            BtnCheckOut.Visible = false;
            BtnBackToHome.Visible = false;

            customerID = cust.CustomerID;
            listCart = CartRepository.getCartListByID(customerID);


            LVAlbumList.DataSource = listCart;
            LVAlbumList.DataBind();

            if (!IsPostBack)
            {
                int total = CalculateTotal();
                if (total == 0)
                {
                    BtnBackToHome.Visible = true;
                    LblError.Text = "There are no items";
                }
                else
                {
                    BtnCheckOut.Visible = true;
                    LblError.Text = "Total Price: Rp. " + total.ToString();
                }
            }
        }

        protected int CalculateTotal()
        {
            int total = 0;

            foreach (Cart item in listCart)
            {
                int subTotal = item.Qty * item.Album.AlbumPrice;
                total += subTotal;
            }

            return total;
        }

        protected void BtnCheckOut_Click(object sender, EventArgs e)
        {
            CartHandler.CheckOut(listCart, customerID);
            Response.Redirect(ResolveUrl("/Home"));
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {

            LinkButton btn = (LinkButton)sender;
            int albumID = int.Parse(btn.CommandArgument);

            CartHandler.DeleteItemFromCart(customerID, albumID);

            Response.Redirect(ResolveUrl("/Cart") + "?CustomerID=" + customerID);
        }

        protected void BtnBackToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect(ResolveUrl("/Home"));
        }
    }
}