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
    public partial class Category_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Category_Management_GUI()
        {
            InitializeComponent();
        }
        int idC = 0;
        int edit = 0;
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            edit = 1;
            showhideEdit();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idC == 0)
            {
                MessageBox.Show("Bạn chưa chọn thể loại cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn thể loại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                edit = 2;
                showhideEdit();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idC == 0)
            {
                MessageBox.Show("Bạn chưa chọn thể loại cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn thể loại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                menuDAO dao = new menuDAO();
                bool a = dao.deleteCategory(idC);
                if(a == true)
                {
                    idC= 0;
                    loadData();
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idC == 0)
            {
                MessageBox.Show("Bạn chưa chọn thể loại cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn thể loại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                menuDAO dao = new menuDAO();
                bool a = dao.restoreCategory(idC);
                if (a == true)
                {
                    idC = 0;
                    loadData();
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkEmpty())
            {
                menuDAO dao = new menuDAO();
                if (edit == 1)
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    // thêm mới
                    Category c = new Category();
                    c.Category_Name = txtName.Text;
                    c.Category_isActive = true;
                    if (dao.addCategory(c))
                    {
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Thêm mới thành công!");
                        clear();
                        idC = 0;
                        edit = 0;
                        showhideEdit();
                    }
                    else
                    {
                        SplashScreenManager.CloseForm();
                    } 
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    //sửa món
                    Category c = new Category();
                    c.Category_ID = idC;
                    c.Category_Name = txtName.Text;
                    if (dao.updateCategory(c))
                    {
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Cập nhật thành công!");
                        clear();
                        idC = 0;
                        edit = 0;
                        showhideEdit();
                    }
                    else
                    {
                        SplashScreenManager.CloseForm();
                    }
                    
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            idC = 0;
            edit = 0;
            showhideEdit();
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcCategory);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvListCategory_Click(object sender, EventArgs e)
        {
            
        }
        void showhideEdit()
        {
            if (edit == 0)
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                txtName.Enabled = false;
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
                txtName.Enabled = true;
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
            menuDAO dao = new menuDAO();
            List<Category> list = dao.getFullListCategory();
            List<CategoryDTO> listDTO = new List<CategoryDTO>();
            foreach (var item in list)
            {
                CategoryDTO dto = new CategoryDTO();
                dto.Category_ID= item.Category_ID;
                dto.Category_Name=item.Category_Name;
                if (item.Category_isActive == true)
                {
                    dto.Category_isActive = "Còn sử dụng";
                }
                else
                {
                    dto.Category_isActive = "Ngừng sử dụng";
                }
                listDTO.Add(dto);
            }
            gcCategory.DataSource = listDTO;
            gvListCategory.OptionsBehavior.Editable = false;
        }
        void clear()
        {
            txtName.Clear();
        }
        bool checkEmpty()
        {
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống thông tin!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
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

        private void PrintGrid(GridControl grid)
        {
            // Check whether the GridControl can be printed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Print.
            grid.Print();
        }

        private void Category_Management_Load(object sender, EventArgs e)
        {
            showhideEdit();
            loadData();
        }

        private void gvListCategory_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idC = int.Parse(gvListCategory.GetFocusedRowCellValue("Category_ID").ToString());
            txtName.Text = gvListCategory.GetFocusedRowCellValue("Category_Name").ToString();
        }
    }
}