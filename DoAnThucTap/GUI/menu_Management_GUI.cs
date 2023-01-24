using CrystalDecisions.Shared;
using DevExpress.Emf;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class menu_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public menu_Management_GUI()
        {
            InitializeComponent();
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
            loadCombobox();
            clear();
        }
        int edit = 0;
        int idP = 0;
        long priceP = 0;
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void showhideEdit()
        {
            if (edit == 0)
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                txtNameProduct.Enabled = false;
                txtPriceProduct.Enabled = false;
                txtUnitProduct.Enabled = false;
                cbbCategory.Enabled = false;
                btnAdd.Enabled= true;
                btnEdit.Enabled= true;
                btnDelete.Enabled= true;
                btnSave.Enabled= false;
                btnCancel.Enabled= false;
                btnPrinter.Enabled= true;
                btnRestore.Enabled= true;
            }
            else
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
                txtNameProduct.Enabled = true;
                txtPriceProduct.Enabled = true;
                txtUnitProduct.Enabled = true;
                cbbCategory.Enabled = true;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnPrinter.Enabled = false;
                btnRestore.Enabled = false;
            }
            
        }
        void loadCombobox()
        {
            cbbCategory.Items.Clear();
            txtUnitProduct.AutoCompleteCustomSource.Clear();
            menuDAO dao = new menuDAO();
            List<Category> list =  dao.getListCategory();
            foreach (var item in list)
            {
                cbbCategory.Items.Add(item.Category_Name);
            }
            AutoCompleteStringCollection list2 = dao.getUnit();
            txtUnitProduct.AutoCompleteCustomSource = list2;

        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        void loadData()
        {
            menuDAO dao = new menuDAO();
            List<Product> list = dao.getFullListMenu();
            List<productDTO> listProduct = new List<productDTO>();
            foreach (var item in list)
            {
                productDTO i = new productDTO();
                i.Product_ID = item.Product_ID;
                i.Product_Name = item.Product_Name;
                i.Product_Image = Base64ToImage(item.Product_Image);
                i.Product_Category = dao.GetCategory(item.Product_Category).Category_Name;
                i.Product_Unit = item.Product_Unit;
                i.Product_Price = String.Format("{0:0,0 vnđ}",item.Product_Price);
                if (item.Product_isActive)
                {
                    i.Product_isActive = "Đang bán";
                }
                else
                {
                    i.Product_isActive = "Ngừng bán";
                }
                listProduct.Add(i);
            }
            gcProduct.DataSource= listProduct;
            gvListProduct.OptionsBehavior.Editable = false;
        }
        private void menu_Management_GUI_Load(object sender, EventArgs e)
        {
            showhideEdit();
            loadData();
        }
        void clear()
        {
            txtNameProduct.Clear();
            txtPriceProduct.Clear();
            txtUnitProduct.Clear();
            cbbCategory.SelectedIndex = 0;
            ptImageProduct.Image = DoAnThucTap.Properties.Resources.noimage;
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            edit = 1;
            showhideEdit();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idP == 0)
            {
                MessageBox.Show("Bạn chưa chọn món cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn món!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                edit = 2;
                showhideEdit();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idP == 0)
            {
                MessageBox.Show("Bạn chưa chọn món cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn món!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                menuDAO dao = new menuDAO();
                var p = dao.getProductbyID(idP);
                if (!p.Product_isActive)
                {
                    MessageBox.Show("Món này đã được ngưng bán rồi! Vui lòng chọn món khác!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn ngưng bán món này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        dao.deleteMenu(idP);
                        idP = 0;
                        MessageBox.Show("Xóa món thành công!");
                        loadData();
                    }
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            idP = 0;
            edit = 0;
            showhideEdit();
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        bool checkEmpty()
        {
            if (txtNameProduct.Text == String.Empty || txtUnitProduct.Text == String.Empty || txtPriceProduct.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống thông tin nào!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                if (priceP == 0)
                {
                    MessageBox.Show("Không được để giá tiền bằng 0!", "Vui lòng điền hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    return false;
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
                    Product p = new Product();
                    p.Product_Name = txtNameProduct.Text;
                    p.Product_Unit = txtUnitProduct.Text;
                    p.Product_Category = dao.getGenreByName(cbbCategory.Text);
                    p.Product_Price = priceP;
                    p.Product_isActive = true;
                    p.Product_Image = ImageToBase64(ptImageProduct.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    dao.addMenu(p);
                    loadData();
                    loadCombobox();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Thêm món thành công!");
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    //sửa món
                    Product p = dao.getProductbyID(idP);
                    p.Product_Name = txtNameProduct.Text;
                    p.Product_Unit = txtUnitProduct.Text;
                    p.Product_Category = dao.getGenreByName(cbbCategory.Text);
                    p.Product_Price = priceP;
                    p.Product_Image = ImageToBase64(ptImageProduct.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    dao.updateMenu(p);
                    loadData();
                    loadCombobox();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Cập nhật thành công!");
                }
                clear();
                idP = 0;
                edit = 0;
                showhideEdit();
            }
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcProduct);
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
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void writePrice()
        {
            if (txtPriceProduct.Text != string.Empty)
            {
                try
                {
                    String p = "";
                    foreach (var item in txtPriceProduct.Text)
                    {
                        if (char.IsDigit(item))
                        {
                            p += item;
                        }
                    }
                    priceP = long.Parse(p);
                }
                catch (Exception)
                {

                    priceP = 0;
                }
                
            }
            else
            {
                priceP = 0;
            }
            
        }
        private void ptImageProduct_Click(object sender, EventArgs e)
        {
            if (edit != 0)
            {
                openfile.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                DialogResult choose = openfile.ShowDialog();
                if (choose == DialogResult.OK)
                {
                    String path = openfile.FileName;
                    Bitmap bt = new Bitmap(Image.FromFile(path));

                    //-- Xuất ra pictureBox 
                    ptImageProduct.Image = bt;
                }
            }
        }

        private void txtPriceProduct_Enter(object sender, EventArgs e)
        {
            txtPriceProduct.SelectAll();
        }

        private void txtPriceProduct_Leave(object sender, EventArgs e)
        {
            writePrice();
            txtPriceProduct.Text = String.Format("{0:0,0 vnđ}", priceP);
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idP == 0)
            {
                MessageBox.Show("Bạn chưa chọn món cần khôi phục! Vui lòng chọn và thử lại!", "Lỗi chưa chọn món!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                menuDAO dao = new menuDAO();
                var p = dao.getProductbyIDDeleted(idP);
                if (p.Product_isActive)
                {
                    MessageBox.Show("Món này vẫn còn đang được bán! Vui lòng chọn món khác!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn khôi phục món này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        dao.restoreMenu(idP);
                        MessageBox.Show("Cập nhật thành công!");
                        idP = 0;
                        loadData();
                    }
                }
            }
        }

        private void gvListProduct_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idP = int.Parse(gvListProduct.GetFocusedRowCellValue("Product_ID").ToString());
            txtNameProduct.Text = gvListProduct.GetFocusedRowCellValue("Product_Name").ToString();
            txtUnitProduct.Text = gvListProduct.GetFocusedRowCellValue("Product_Unit").ToString();
            txtPriceProduct.Text = gvListProduct.GetFocusedRowCellValue("Product_Price").ToString();
            writePrice();
            cbbCategory.Text = gvListProduct.GetFocusedRowCellValue("Product_Category").ToString();
            ptImageProduct.Image = (Image)gvListProduct.GetFocusedRowCellValue("Product_Image");
        }

        private void txtUnitProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
