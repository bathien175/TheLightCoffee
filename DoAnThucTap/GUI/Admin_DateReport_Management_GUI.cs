using DevExpress.XtraEditors;
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
    public partial class Admin_DateReport_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        private long moneyin = 0, moneyout = 0, moneyimport = 0;
        public Admin_DateReport_Management_GUI()
        {
            InitializeComponent();
            loadData();
            loadMoney();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            printReportDate date = new printReportDate();
            date.ShowDialog();
        }

        void loadData()
        {
            BudgetDAO dao = new BudgetDAO();
            List<exportDate_Result> list = dao.getListDate();
            List<dateReport> dateDTO = new List<dateReport>();
            int iid = 1;
            foreach (var item in list)
            {
                dateReport dto = new dateReport();
                dto.IDExport = iid;
                dto.NameExport = item.NameExport;
                dto.StaffExport = item.StaffExport;
                if (item.TypeExport == 0 || item.TypeExport == 1)
                {
                    dto.MoneyExport = String.Format("{0:0,0 vnđ}", item.MoneyExport);
                    if (item.TypeExport == 0)
                    {
                        dto.TypeExport = "Thu";
                        moneyin += convertLong(dto.MoneyExport);
                    }
                    else
                    {
                        dto.TypeExport = "Nhập";
                        moneyimport += convertLong(dto.MoneyExport);
                    }
                }
                else
                {
                    dto.TypeExport = "Chi";
                    dto.MoneyExport = "-" + String.Format("{0:0,0 vnđ}", item.MoneyExport);
                    moneyout += convertLong(dto.MoneyExport);
                }
                dateDTO.Add(dto);
                iid++;
            }
            gcProduct.DataSource = dateDTO;
            gvListProduct.OptionsBehavior.Editable = false;
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
        void loadMoney()
        {
            btnReceipt.getMoney = moneyin;
            btnPayment.getMoney = moneyout;
            btnImportMoney.getMoney = moneyimport;
            btnTotalMoney.getMoney = moneyin;
        }
    }
}