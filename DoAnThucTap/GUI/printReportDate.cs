using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Office.Utils;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class printReportDate : Form
    {
        private long tBill=0, tImport=0, tMoney = 0;
        public printReportDate()
        {
            InitializeComponent();
            List<dateReport> list = getdata();
            loadData(list,tBill,tImport,tMoney);
        }
        List<dateReport> getdata()
        {
            billDAO dao = new billDAO();
            List<exportDate_Result> list = dao.GetExportDate_Results();
            List < dateReport > listdata = new List<dateReport>();
            foreach (var item in list)
            {
                dateReport da = new dateReport();
                da.NameExport = item.NameExport.ToString();
                da.ProductExport = item.ProductExport.ToString();
                da.QuantityExport = Convert.ToInt32(item.QuantityExport);
                da.PriceExport= Convert.ToInt64(item.PriceExport);
                da.UnitExport = item.UnitExport.ToString();
                da.Bill_ExtraFee = Convert.ToInt64(item.Bill_ExtraFee);
                da.Bill_Discount = Convert.ToInt64(item.Bill_Discount);             
                if (item.type == 0 || item.type == 1)
                {
                    da.TotalMoney = (da.PriceExport * da.QuantityExport) + da.Bill_ExtraFee - da.Bill_Discount;
                    da.type = "Thu";
                    tBill += da.TotalMoney;
                    tMoney += da.TotalMoney;
                }
                else
                {
                    da.TotalMoney = -(da.PriceExport * da.QuantityExport);
                    da.type = "Chi";
                    tImport += -da.TotalMoney;
                    tMoney -= -da.TotalMoney;
                }
                listdata.Add(da);
            }
            return listdata;
        }
        void loadData(List<dateReport> list,long totalbill, long totalimport, long totalmoney)
        {
            ReportDate report = new ReportDate();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(list, totalbill, totalimport, totalmoney);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
