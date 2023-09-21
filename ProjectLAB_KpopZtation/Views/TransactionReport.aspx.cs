using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectLAB_KpopZtation.Reporting;
using ProjectLAB_KpopZtation.Model;
using ProjectLAB_KpopZtation.Controller;
namespace ProjectLAB_KpopZtation.Views
{
    public partial class TransactionReport : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = detailData(TransactionController.GetAllTrHeader());
            report.SetDataSource(data);
        }
        private DataSet1 detailData(List<TransactionHeader> transactions)
        {
            DataSet1 newData = new DataSet1();
            var headerTable = newData.TransactionHeader;
            var detailTable = newData.TransactionDetail;

            foreach (TransactionHeader tr in transactions)
            {
                List<object> trdetails = TransactionController.GetReport(tr.TransactionID);
                int GrandTotal = 0;
                foreach (var detail in trdetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = detail.GetType().GetProperty("TransactionID").GetValue(detail);
                    drow["AlbumName"] = detail.GetType().GetProperty("AlbumName").GetValue(detail);
                    drow["Quantity"] = detail.GetType().GetProperty("Quantity").GetValue(detail);
                    drow["AlbumPrice"] = detail.GetType().GetProperty("AlbumPrice").GetValue(detail);
                    int subtotal = (int)detail.GetType().GetProperty("Quantity").GetValue(detail) * (int)detail.GetType().GetProperty("AlbumPrice").GetValue(detail);
                    drow["SubTotalValue"] = subtotal;
                    GrandTotal = GrandTotal + subtotal;
                    detailTable.Rows.Add(drow);
                }
                var row = headerTable.NewRow();
                row["TransactionID"] = tr.TransactionID;
                row["CustomerID"] = tr.CustomerID;
                row["TransactionDate"] = tr.TransactionDate;
                row["GrandTotalValue"] = GrandTotal;
                headerTable.Rows.Add(row);
            }
            return newData;
        }
    }
}