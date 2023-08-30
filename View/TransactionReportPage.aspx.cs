using KpopZtation.Dataset;
using KpopZtation.Handler;
using KpopZtation.Model;
using KpopZtation.Report;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
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

                if (!cust.CustomerRole.Equals("ADM"))
            {
                Response.Redirect("/Home");
            }
        }

        KpopZtationReport report = new KpopZtationReport();
            CrystalReportViewer1.ReportSource = report;
            KpopZtationDS data = GetData(TransactionHandler.GetAllTransactions());
            report.SetDataSource(data);
        }

        private KpopZtationDS GetData(List<TransactionHeader> transactions)
        {
            KpopZtationDS data = new KpopZtationDS();
            var headerTable = data.HeaderTable;
            var detailTable = data.DetailTable;

            foreach (TransactionHeader tran in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = tran.TransactionID;
                hrow["CustomerID"] = tran.CustomerID;
                hrow["TransactionDate"] = tran.TransactionDate.ToString("dd/MM/yyyy");
                hrow["GrandTotal"] = "Rp " + tran.TransactionDetails.Sum(x => x.Qty * x.Album.AlbumPrice).ToString();
                headerTable.Rows.Add(hrow);

                foreach (TransactionDetail tranDet in tran.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = tranDet.TransactionID;
                    drow["AlbumName"] = tranDet.Album.AlbumName;
                    drow["Qty"] = tranDet.Qty;
                    drow["AlbumPrice"] = "Rp " + tranDet.Album.AlbumPrice;
                    drow["SubTotal"] = "Rp " + (tranDet.Qty * tranDet.Album.AlbumPrice);
                    detailTable.Rows.Add(drow);
                }
            }

            return data;
        }


    }
}