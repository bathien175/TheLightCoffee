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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class Ingredient_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Ingredient_Management_GUI()
        {
            InitializeComponent();
        }
        int idI = 0;
        int edit = 0;
        long priceI = 0;
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
                MessageBox.Show("Bạn chưa chọn sản phẩm cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn sản phẩm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn sản phẩm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IngredientDAO dao = new IngredientDAO();
                var p = dao.getIngredientbyID(idI);
                if (!p.Ingredient_isActive)
                {
                    MessageBox.Show("Món này đã được ngưng bán rồi! Vui lòng chọn món khác!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn ngưng bán món này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        dao.deleteIngredient(idI);
                        idI = 0;
                        MessageBox.Show("Xóa món thành công!");
                        loadData();
                    }
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == 0)
            {
                MessageBox.Show("Bạn chưa chọn món cần khôi phục! Vui lòng chọn và thử lại!", "Lỗi chưa chọn món!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IngredientDAO dao = new IngredientDAO();
                var p = dao.getIngredientbyID(idI);
                if (p.Ingredient_isActive)
                {
                    MessageBox.Show("Món này vẫn còn đang được bán! Vui lòng chọn món khác!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn khôi phục món này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        dao.restoreIngredient(idI);
                        MessageBox.Show("Cập nhật thành công!");
                        idI = 0;
                        loadData();
                    }
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkEmpty())
            {
                IngredientDAO dao = new IngredientDAO();
                if (edit == 1)
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    // thêm mới
                    Ingredient p = new Ingredient();
                    p.Ingredient_Name = txtName.Text;
                    p.Ingredient_Unit = txtUnit.Text;
                    p.Ingredient_PriceImport = priceI;
                    p.Ingredient_isActive = true;
                    p.Ingredient_Reserved = 0;
                    p.Ingredient_Image = ImageToBase64(ptImage.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    dao.addIngredient(p);
                    loadData();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    //sửa món
                    Ingredient p = dao.getIngredientbyID(idI);
                    p.Ingredient_Name = txtName.Text;
                    p.Ingredient_Unit = txtUnit.Text;
                    p.Ingredient_PriceImport = priceI;
                    p.Ingredient_Image = ImageToBase64(ptImage.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    dao.updateIngredient(p);
                    loadData();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Cập nhật thành công!");
                }
                clear();
                idI = 0;
                edit = 0;
                showhideEdit();
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
            ShowGridPreview(gcIngredient);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvListIngredient_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.SelectAll();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            writePrice();
            txtPrice.Text = String.Format("{0:0,0 vnđ}", priceI);
        }
        void writePrice()
        {
            if (txtPrice.Text != string.Empty)
            {
                try
                {
                    String p = "";
                    foreach (var item in txtPrice.Text)
                    {
                        if (char.IsDigit(item))
                        {
                            p += item;
                        }
                    }
                    priceI = long.Parse(p);
                }
                catch (Exception)
                {

                    priceI = 0;
                }

            }
            else
            {
                priceI = 0;
            }

        }
        void showhideEdit()
        {
            if (edit == 0)
            {
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;
                txtName.Enabled = false;
                txtPrice.Enabled = false;
                txtUnit.Enabled = false;
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
                txtPrice.Enabled = true;
                txtUnit.Enabled = true;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnPrinter.Enabled = false;
                btnRestore.Enabled = false;
            }

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
            IngredientDAO dao = new IngredientDAO();
            List<Ingredient> list = dao.getFullIngredient2();
            List<ingredientDTO> listIngredient = new List<ingredientDTO>();
            foreach (var item in list)
            {
                ingredientDTO i = new ingredientDTO();
                i.Ingredient_ID = item.Ingredient_ID;
                i.Ingredient_Name = item.Ingredient_Name;
                i.Ingredient_Image = Base64ToImage(item.Ingredient_Image);
                i.Ingredient_Reserved = (double)item.Ingredient_Reserved;
                i.Ingredient_Unit = item.Ingredient_Unit;
                i.Ingredient_PriceImport = String.Format("{0:0,0 vnđ}", item.Ingredient_PriceImport);
                if (item.Ingredient_isActive)
                {
                    i.Ingredient_isActive = "Đang bán";
                }
                else
                {
                    i.Ingredient_isActive = "Ngừng bán";
                }
                listIngredient.Add(i);
            }
            gcIngredient.DataSource = listIngredient;
            gvListIngredient.OptionsBehavior.Editable = false;
        }

        private void Ingredient_Management_GUI_Load(object sender, EventArgs e)
        {
            showhideEdit();
            loadData();
        }
        void clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtUnit.Clear();
            ptImage.Image = DoAnThucTap.Properties.Resources.noimage;
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
            if (txtName.Text == String.Empty || txtUnit.Text == String.Empty || txtPrice.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống thông tin nào!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                if (priceI == 0)
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

        private void ptImage_Click(object sender, EventArgs e)
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
                    ptImage.Image = bt;
                }
            }
        }

        private void gvListIngredient_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idI = int.Parse(gvListIngredient.GetFocusedRowCellValue("Ingredient_ID").ToString());
            txtName.Text = gvListIngredient.GetFocusedRowCellValue("Ingredient_Name").ToString();
            txtUnit.Text = gvListIngredient.GetFocusedRowCellValue("Ingredient_Unit").ToString();
            txtPrice.Text = gvListIngredient.GetFocusedRowCellValue("Ingredient_PriceImport").ToString();
            writePrice();
            ptImage.Image = (Image)gvListIngredient.GetFocusedRowCellValue("Ingredient_Image");
        }
    }
}