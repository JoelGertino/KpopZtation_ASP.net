using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Repository;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Handler
{
    public class TransactionHandler
    {
        TransactionRepository TR = new TransactionRepository();

        public static TransactionHeader CreateTrHeader(int UserID, DateTime transactionDate)
        {
            return TransactionRepository.CreateTrHeader(UserID, transactionDate);
        }

        public static void CreateTrDetail(int transactionID, int ItemID, int quantity)
        {
            TransactionRepository.CreateTrDetail(transactionID, ItemID, quantity);
        }

        public List<object> GetAllTransaction(int UserID)
        {
            return TR.GetAllTransactionHeader(UserID);
        }

        public static List<TransactionDetail> GetAllTransactionDetail(int TransactionID)
        {
            return TransactionRepository.GetAllTrDetail(TransactionID);
        }

        public static List<object> GetReport(int TransactionID)
        {

            return TransactionRepository.GetReport(TransactionID);
        }

        public static List<TransactionHeader> GetAllTrHeader()
        {
            return TransactionRepository.GetAllTrHeader();
        }
        public void CreateTransactionDetail(int transactionID, int ItemID, int quantity)
        {
            TR.CreateTransactionDetail(transactionID, ItemID, quantity);
        }
    }
}