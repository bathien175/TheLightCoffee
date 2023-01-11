using DevExpress.XtraEditors;
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
    public partial class Date_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        private long moneyin = 0, moneyout = 0, moneytotal = 0, moneyimport = 0, newmoney = 0;
        private String staffcur;
        public Date_Management_GUI(string staffcur)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            InitializeComponent();
            loadData();
            loadMoney();
            cbbType.SelectedIndex = 0;
            showhideEdit(false);
            this.staffcur = staffcur;
            SplashScreenManager.CloseForm();
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
                if(item.TypeExport == 0 || item.TypeExport == 1)
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
                    dto.MoneyExport = "-"+String.Format("{0:0,0 vnđ}", item.MoneyExport);
                    moneyout += convertLong(dto.MoneyExport);
                }
                dateDTO.Add(dto);
                iid++;
            }
            moneytotal = moneyin - moneyout;
            gcProduct.DataSource = dateDTO;
            gvListProduct.OptionsBehavior.Editable = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
            showhideEdit(true);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //them phieu
            if (checkEmpty())
            {
                MessageBox.Show("Không được để trống thông tin!","Lỗi trống tiêu đề phiếu!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if ((newmoney % 1000) != 0)
                {
                    MessageBox.Show("Số tiền không hợp lệ!", "Lỗi thông tin không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    BudgetDAO dao = new BudgetDAO();
                    if (cbbType.SelectedIndex == 2) //phiếu chi
                    {
                        if(convertLong(txtTotalMoney.Text)> (moneytotal + moneyimport))
                        {
                            SplashScreenManager.CloseForm();
                            MessageBox.Show("Số tiền vượt quá số tiền hiện có trong ngân sách! Vui lòng nhập thêm tiền và thử lại sau!", "Lỗi thiếu tiền!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Payment p = new Payment();
                            p.Payment_time = DateTime.Now;
                            p.Payment_money = convertLong(txtTotalMoney.Text);
                            p.Payment_name = txtName.Text;
                            p.Payment_Staff = staffcur;
                            dao.addPayment(p);
                            Clear();
                            showhideEdit(false);
                            loadData();
                            loadMoney();
                            SplashScreenManager.CloseForm();
                            MessageBox.Show("Thêm phiếu thành công!");
                        }
                    }
                    else // phiếu nhập
                    {
                        receipt r = new receipt();
                        r.receipt_Staff = staffcur;
                        r.receipt_time = DateTime.Now;
                        r.receipt_name = txtName.Text;
                        r.receipt_money= convertLong(txtTotalMoney.Text);
                        if (cbbType.SelectedIndex == 0)
                        {
                            r.receipt_isMoneyImport = false;
                        }
                        else
                        {
                            r.receipt_isMoneyImport = true;
                        }
                        dao.addReceipts(r);
                        Clear();
                        showhideEdit(false);
                        loadData();
                        loadMoney();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Thêm phiếu thành công!");
                    }
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
            showhideEdit(false);
        }

        private void btnReserved_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_QuantityIngredient_GUI check = new check_QuantityIngredient_GUI();
            check.ShowDialog();
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            printReportDate date = new printReportDate();
            date.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void Clear()
        {
            txtName.Clear();
            txtTotalMoney.Clear();
            newmoney = 0;
        }
        void showhideEdit(bool s)
        {
            if (!s)
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                txtName.Enabled = false;
                btnIn.Enabled = true;
                cbbType.Enabled = false;
                txtTotalMoney.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnReserved.Enabled = true;
                btnPrinter.Enabled = true;
            }
            else
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
                txtName.Enabled = true;
                btnIn.Enabled = false;
                cbbType.Enabled = true;
                txtTotalMoney.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnReserved.Enabled = false;
                btnPrinter.Enabled = false;
            }

        }

        private void txtTotalMoney_Enter(object sender, EventArgs e)
        {

        }
        private bool checkEmpty()
        {
            if (txtName.Text == String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtTotalMoney_Leave(object sender, EventArgs e)
        {
            String s = "";
            if (txtTotalMoney.Text != String.Empty)
            {
                foreach (var item in txtTotalMoney.Text)
                {
                    if (char.IsDigit(item))
                    {
                        s += item;
                    }
                }
            }
            if (s != "")
            {
                newmoney = long.Parse(s);
                txtTotalMoney.Text = String.Format("{0:0,0 vnđ}", newmoney);
            }
            else
            {
                newmoney = 0;
                txtTotalMoney.Text = String.Format("{0:0,0 vnđ}", newmoney);
            }
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        void loadMoney()
        {
            moneyIn.getMoney = moneyin;
            moneyOut.getMoney = moneyout;
            moneyDate.getMoney = moneytotal;
            moneyAll.getMoney = moneytotal + moneyimport;
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
    }
}