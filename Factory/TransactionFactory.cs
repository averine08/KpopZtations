using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class TransactionFactory
    {

        public static TransactionHeader createNewTransactionHeader(DateTime date, int customerID)
        {
            TransactionHeader newTransactionHeader = new TransactionHeader();
            newTransactionHeader.TransactionDate = date;
            newTransactionHeader.CustomerID = customerID;

            return newTransactionHeader;
        }

        public static TransactionDetail createNewTransactionDetail(int transactionID, int albumID, int qty)
        {
            TransactionDetail newTransactionDetail = new TransactionDetail();
            newTransactionDetail.TransactionID = transactionID;
            newTransactionDetail.AlbumID = albumID;
            newTransactionDetail.Qty = qty;

            return newTransactionDetail;
        }
    }
}