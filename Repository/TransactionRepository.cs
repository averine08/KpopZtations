using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        private static KpopZtationDBEntities db = DatabaseSingleton.GetInstance();
        public static List<TransactionHeader> GetAllTransactions()
        {
            return db.TransactionHeaders.ToList();
        }

        public static TransactionHeader GetTransactionById(int id)
        {
            return (from x in db.TransactionHeaders where x.TransactionID == id select x).FirstOrDefault();
        }

        public static List<TransactionHeader> GetTransactionByCustId(int custId)
        {
            return (from x in db.TransactionHeaders where x.CustomerID == custId select x).ToList();
        }

        public static int insertTransactionHeader(DateTime date, int customerID)
        {
            TransactionHeader newTransactionHeader = TransactionFactory.createNewTransactionHeader(date, customerID);
            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();
            return newTransactionHeader.TransactionID;
        }

        public static void insertTransactionDetail(int transactionID, int albumID, int qty)
        {
            TransactionDetail newTransactionDetail = TransactionFactory.createNewTransactionDetail(transactionID, albumID, qty);
            db.TransactionDetails.Add(newTransactionDetail);
            db.SaveChanges();
        }

        public static void DeleteTransactionDetailsByAlbum(List<TransactionDetail> tranDetList)
        {
            db.TransactionDetails.RemoveRange(tranDetList);
            db.SaveChanges();
            return;
        }

        public static void DeleteTransactionHeader(TransactionHeader trans)
        {
            db.TransactionHeaders.Remove(trans);
            db.SaveChanges();
            return;
        }
    }
}