using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Handler;

using ProjectLAB_KpopZtation.Model;

namespace ProjectLAB_KpopZtation.Controller
{
    public class TransactionController
    {
        Database1Entities db = new Database1Entities();
        TransactionHandler TH = new TransactionHandler();
        public static int InsertTransaction(int UserID)
        {
            TransactionHeader header = TransactionHandler.CreateTrHeader(UserID, DateTime.Now);
            return header.TransactionID;
        }

        public static void InsertTransactionDetail(int headerid, int ItemID, int quantity)
        {
            TransactionHandler.CreateTrDetail(headerid, ItemID, quantity);
        }

        public List<object> GetAllTransaction(int UserID)
        {
            return TH.GetAllTransaction(UserID);
        }
        public static List<TransactionDetail> GetAllTransactionDetail(int TransactionID)
        {
            return TransactionHandler.GetAllTransactionDetail(TransactionID);
        }

        public static List<object> GetReport(int TransactionID)
        {

            return TransactionHandler.GetReport(TransactionID);
        }

        public static List<TransactionHeader> GetAllTrHeader()
        {
            return TransactionHandler.GetAllTrHeader();
        }
        public void CreateTransactionDetail(int transactionID, int ItemID, int quantity)
        {
            TH.CreateTransactionDetail(transactionID, ItemID, quantity);
        }
    }
}