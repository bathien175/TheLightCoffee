using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class Admin_ReportByDate_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        private long moneyin = 0, moneyout = 0, moneytotal = 0, moneyimport = 0;
        public Admin_ReportByDate_Management_GUI()
        {
            InitializeComponent();
            dtpkChooseDate.EditValue = DateTime.Now;
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            loadData();
            loadMoney();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            moneyin = 0;
            moneyout = 0;
            moneytotal = 0; 
            moneyimport = 0;
            BudgetDAO dao = new BudgetDAO();
            List<exportbyDate_Result> list = dao.getListByDate(Convert.ToDateTime(dtpkChooseDate.EditValue.ToString()));
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
            moneytotal = moneyin - moneyout;
            gcProduct.DataSource = dateDTO;
            gvListProduct.OptionsBehavior.Editable = false;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcProduct);
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
            btnTotalMoney.getMoney = moneytotal;
        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
    }
}