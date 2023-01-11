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
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class Discount_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Discount_Management_GUI()
        {
            InitializeComponent();
            showhideEdit();
            loadData();
        }
        int idI = 0;
        int edit = 0;
        private void gvListDiscount_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idI = Convert.ToInt32(gvListDiscount.GetFocusedRowCellValue("Discount_ID").ToString());
            txtName.Text = gvListDiscount.GetFocusedRowCellValue("Discount_Name").ToString();
            String s = gvListDiscount.GetFocusedRowCellValue("Discount_Type").ToString();
            if(s=="Toàn sản phẩm")
            {
                btnAllproduct.Checked = true;
            }
            else
            {
                btnAllproduct.Checked = false;
            }
            nbrPer.Value = Convert.ToDecimal(gvListDiscount.GetFocusedRowCellValue("Discount_Per").ToString());
            dtpkDateStart.Value = Convert.ToDateTime(gvListDiscount.GetFocusedRowCellValue("Discount_DateStart").ToString());
            String de = gvListDiscount.GetFocusedRowCellValue("Discount_DateEnd").ToString();
            if(de=="Chưa kết thúc")
            {
                dtpkDateEnd.Value = DateTime.Now;
            }
            else
            {
                dtpkDateEnd.Value = Convert.ToDateTime(de);
            }
        }

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
                MessageBox.Show("Bạn chưa chọn mã giảm giá cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn mã giảm giá!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bạn chưa chọn mã giảm giá cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn mã giảm giá!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code xóa discount
                BudgetDAO dao = new BudgetDAO();
                var p = dao.getDiscount(idI);
                if (p.Discount_DateEnd!=null)
                {
                    MessageBox.Show("Mã giảm giá này đã được ngưng sử dụng từ trước đó!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn ngưng sử dụng mã giảm giá này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.deleteDiscount(idI);
                        idI = 0;
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Xóa mã giảm giá thành công!");
                    }
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã giảm giá cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn mã giảm giá!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code khôi phục discount
                BudgetDAO dao = new BudgetDAO();
                var p = dao.getDiscount(idI);
                if (p.Discount_DateEnd == null)
                {
                    MessageBox.Show("Mã giảm giá này vẫn còn được sử dụng!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn sử dụng lại mã giảm giá này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.restoreDiscount(idI);
                        idI = 0;
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Xóa mã giảm giá thành công!");
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
                    Discount p = new Discount();
                    p.Discount_name = txtName.Text;
                    p.Discount_Per = Convert.ToInt32(nbrPer.Value);
                    p.Discount_DateStart = DateTime.Now;
                    p.Discount_DateEnd = null;
                    if (btnAllproduct.Checked == true)
                    {
                        p.Discount_allProduct = true;
                    }
                    else
                    {
                        p.Discount_allProduct = false;
                    }
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    dao.addDiscount(p);
                    loadData();
                    clear();
                    idI = 0;
                    edit = 0;
                    showhideEdit();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Thêm mã giảm giá thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    //sửa món
                    Discount t = dao.getDiscount(idI);
                    t.Discount_name = txtName.Text;
                    t.Discount_Per = Convert.ToInt32(nbrPer.Value);
                    if (btnAllproduct.Checked == true)
                    {
                        t.Discount_allProduct = true;
                    }
                    else
                    {
                        t.Discount_allProduct = false;
                    }
                    dao.updateDiscount(t);
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

        private bool checkEmpty()
        {
            if(txtName.Text == String.Empty)
            {
                MessageBox.Show("Không được để trống tên mã giảm giá","Lỗi thông tin không hợp lệ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return true;
            }else if(nbrPer.Value == 0)
            {
                MessageBox.Show("Giá trị giảm giá không được bằng 0", "Lỗi thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            } else
            {
                return false;
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
            ShowGridPreview(gcDiscount);
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
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void showhideEdit()
        {
            if (edit == 0)
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                btnApply.Enabled = true;
                nbrPer.Enabled= false;
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
                if (edit == 2)
                {
                    dtpkDateStart.Enabled = false;
                    dtpkDateEnd.Enabled = false;
                }
                else
                {
                    dtpkDateStart.Enabled = false;
                    dtpkDateEnd.Enabled = false;
                }
                btnApply.Enabled = false;
                nbrPer.Enabled = true;
                btnAllproduct.Enabled = true;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnPrinter.Enabled = false;
                btnRestore.Enabled = false;
            }

        }
        void clear()
        {
            txtName.Clear();
            nbrPer.Value = 0;
        }
        void loadData()
        {
            BudgetDAO dao = new BudgetDAO();
            List<Discount> list = dao.getFullListDiscount();
            List<DiscountDTO> discountDTOs = new List<DiscountDTO>();
            foreach (var item in list)
            {
                DiscountDTO dto = new DiscountDTO();
                dto.Discount_ID = item.Discount_ID;
                dto.Discount_Name = item.Discount_name;
                dto.Discount_DateStart = Convert.ToDateTime(item.Discount_DateStart).ToShortDateString();
                if (item.Discount_DateEnd == null)
                {
                    dto.Discount_DateEnd = "Chưa kết thúc";
                }
                else
                {
                    dto.Discount_DateEnd = Convert.ToDateTime(item.Discount_DateEnd).ToShortDateString();
                }
                dto.Discount_Per = (int)item.Discount_Per;
                if (item.Discount_allProduct==true)
                {
                    dto.Discount_Type = "Toàn sản phẩm";
                }
                else
                {
                    dto.Discount_Type = "Sản phẩm chọn lựa";
                }
                discountDTOs.Add(dto);
            }
            gcDiscount.DataSource = discountDTOs;
            gvListDiscount.OptionsBehavior.Editable = false;
        }
    }
}