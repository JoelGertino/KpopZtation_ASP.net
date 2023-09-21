using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLAB_KpopZtation.Model;
namespace ProjectLAB_KpopZtation.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTrHeader(int UserID, DateTime transactionDate)
        {
            return new TransactionHeader
            {
                CustomerID = UserID,
                TransactionDate = transactionDate
            };
        }

        public static TransactionDetail CreateTrDetail(int transactionID, int itemID, int quantity)
        {
            return new TransactionDetail
            {
                TransactionID = transactionID,
                AlbumID = itemID,
                Qty = quantity
            };
        }
    }
}