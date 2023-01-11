using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class ExtraFee_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public ExtraFee_Management_GUI()
        {
            InitializeComponent();
            showhideEdit();
            loadData();
        }
        int idI = 0;
        int edit = 0;
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            edit = 1;
            showhideEdit();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == 0)
            {
                MessageBox.Show("Bạn chưa chọn phụ thu cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn phụ thu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                edit = 2;
                showhideEdit();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == 0)
            {
                MessageBox.Show("Bạn chưa chọn phụ thu cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn phụ thu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code xóa discount
                BudgetDAO dao = new BudgetDAO();
                var p = dao.getSurcharge(idI);
                if (p.Surcharge_DateEnd != null)
                {
                    MessageBox.Show("Phí phụ thu này đã được ngưng sử dụng từ trước đó!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn ngưng sử dụng phí phụ thu này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.deleteSurcharge(idI);
                        idI = 0;
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Xóa phí phụ thu thành công!");
                    }
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == 0)
            {
                MessageBox.Show("Bạn chưa chọn phí phụ thu cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn phí phụ thu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code khôi phục discount
                BudgetDAO dao = new BudgetDAO();
                var p = dao.getSurcharge(idI);
                if (p.Surcharge_DateEnd == null)
                {
                    MessageBox.Show("Phí phụ thu này vẫn còn được sử dụng!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn sử dụng lại phí phụ thu này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.restoreSurcharge(idI);
                        idI = 0;
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Phục hồi phí phụ thu thành công!");
                    }
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkEmpty())
            {
                BudgetDAO dao = new BudgetDAO();
                if (edit == 1)
                {
                    // thêm mới
                    Surcharge p = new Surcharge();
                    p.Surcharge_Name = txtName.Text;
                    p.Surcharge_Price = convertMoneytoLong();
                    p.Surcharge_DateStart = DateTime.Now;
                    p.Surcharge_DateEnd = null;
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    dao.addSurcharge(p);
                    loadData();
                    clear();
                    idI = 0;
                    edit = 0;
                    showhideEdit();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Thêm phí phụ thu thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    //sửa món
                    Surcharge t = dao.getSurcharge(idI);
                    t.Surcharge_Name = txtName.Text;
                    t.Surcharge_Price = convertMoneytoLong();
                    dao.updateSurcharge(t);
                    loadData();
                    clear();
                    idI = 0;
                    edit = 0;
                    showhideEdit();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            idI = 0;
            edit = 0;
            showhideEdit();
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcExtraFee);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvListExtraFee_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idI = Convert.ToInt32(gvListExtraFee.GetFocusedRowCellValue("Surcharge_ID").ToString());
            txtName.Text = gvListExtraFee.GetFocusedRowCellValue("Surcharge_Name").ToString();
            txtMoney.Text = String.Format("{0:0,0 vnđ}", long.Parse(gvListExtraFee.GetFocusedRowCellValue("Surcharge_Price").ToString()));
            dtpkDateStart.Value = Convert.ToDateTime(gvListExtraFee.GetFocusedRowCellValue("Surcharge_DateStart").ToString());
            String de = gvListExtraFee.GetFocusedRowCellValue("Surcharge_DateEnd").ToString();
            if (de == "Chưa kết thúc")
            {
                dtpkDateEnd.Value = DateTime.Now;
            }
            else
            {
                dtpkDateEnd.Value = Convert.ToDateTime(de);
            }
        }
        private bool checkEmpty()
        {
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Không được để trống tên mã giảm giá", "Lỗi thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (convertMoneytoLong() == 0)
            {
                MessageBox.Show("Giá trị không được bằng 0", "Lỗi thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        long convertMoneytoLong()
        {
            String s = "";
            foreach (var item in txtMoney.Text)
            {
                if (char.IsDigit(item))
                {
                    s += item;
                }
            }
            return long.Parse(s);
        }
        private void ShowGridPreview(GridControl gcTable)
        {
            // Check whether the GridControl can be previewed.
            if (!gcTable.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            gcTable.ShowPrintPreview();
        }
        void clear()
        {
            txtName.Clear();
            txtMoney.Text = "0 VNĐ";
        }
        void showhideEdit()
        {
            if (edit == 0)
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnPrinter.Enabled = true;
                btnRestore.Enabled = true;
            }
            else
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
                dtpkDateStart.Enabled = false;
                dtpkDateEnd.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnPrinter.Enabled = false;
                btnRestore.Enabled = false;
            }

        }
        void loadData()
        {
            BudgetDAO dao = new BudgetDAO();
            List<Surcharge> list = dao.getFullListSurcharge();
            List<SurchargeDTO> surchargeDTOs = new List<SurchargeDTO>();
            foreach (var item in list)
            {
                SurchargeDTO dto = new SurchargeDTO();
                dto.Surcharge_ID = item.Surcharge_ID;
                dto.Surcharge_Name = item.Surcharge_Name;
                dto.Surcharge_DateStart = Convert.ToDateTime(item.Surcharge_DateStart).ToShortDateString();
                if (item.Surcharge_DateEnd == null)
                {
                    dto.Surcharge_DateEnd = "Chưa kết thúc";
                }
                else
                {
                    dto.Surcharge_DateEnd = Convert.ToDateTime(item.Surcharge_DateEnd).ToShortDateString();
                }
                dto.Surcharge_Price = (int)item.Surcharge_Price;
                surchargeDTOs.Add(dto);
            }
            gcExtraFee.DataSource = surchargeDTOs;
            gvListExtraFee.OptionsBehavior.Editable = false;
        }

        private void txtMoney_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtMoney_Leave(object sender, EventArgs e)
        {
            txtMoney.Text = String.Format("{0:0,0 vnđ}", convertMoneytoLong());
        }
    }
}