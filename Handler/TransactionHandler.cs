using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetAllTransactions()
        {
            return TransactionRepository.GetAllTransactions();
        }

        public static void CheckEmptyTransactions()
        {
            List<TransactionHeader> transList = TransactionRepository.GetAllTransactions();
            foreach(var trans in transList){
                if(trans.TransactionDetails.Count() == 0)
                {
                    TransactionRepository.DeleteTransactionHeader(trans);
                }
            }
        }
    }
}