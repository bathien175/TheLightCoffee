using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraSplashScreen;
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
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            InitializeComponent();
            List<dateReport> list = getdata();
            loadData(list,tBill,tImport,tMoney);
            SplashScreenManager.CloseForm();
        }
        List<dateReport> getdata()
        {
            billDAO dao = new billDAO();
            List<exportDate_Result> list = dao.GetExportDate_Results();
            List <dateReport> listdata = new List<dateReport>();
            foreach (var item in list)
            {
                dateReport da = new dateReport();
                da.NameExport = item.NameExport;
                da.StaffExport = item.StaffExport;
                if(item.TypeExport== 1 || item.TypeExport == 0)
                {
                    if(item.TypeExport == 1)
                    {
                        da.TypeExport = "Nhập";
                        da.MoneyExport = String.Format("{0:0,0 vnđ}", item.MoneyExport);
                    }
                    else
                    {
                        da.TypeExport = "Thu";
                        da.MoneyExport = String.Format("{0:0,0 vnđ}", item.MoneyExport);
                        tBill += convertLong(da.MoneyExport);
                    }
                }
                else
                {
                    da.TypeExport = "Chi";
                    da.MoneyExport = String.Format("{0:0,0 vnđ}", -item.MoneyExport);
                    tImport += convertLong(da.MoneyExport);
                }
                listdata.Add(da);
            }
            tMoney = tBill - tImport;
            return listdata;
        }
        long convertLong(String s)
        {
            string strlong = "";
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                {
                    strlong += item;
                }
            }
            return Convert.ToInt64(strlong);
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
