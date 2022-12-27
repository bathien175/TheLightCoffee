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
    public partial class Staff_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Staff_Management_GUI()
        {
            InitializeComponent();
        }
        String idS = "";
        int edit = 0;
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            edit = 1;
            showhideEdit();
            txtStaffCode.Enabled= true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idS == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                edit = 2;
                showhideEdit();
                txtStaffCode.Enabled = false;
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idS == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                staffDAO dao = new staffDAO();
                var s = dao.findStaff(idS);
                if (!s.Staff_isActive)
                {
                    MessageBox.Show("Nhân viên này đã bị xóa rồi! Vui lòng chọn lại!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        dao.deleteStaff(idS);
                        idS = "";
                        MessageBox.Show("Xóa nhân viên thành công!");
                        loadData();
                    }
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idS == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần khôi phục! Vui lòng chọn và thử lại!", "Lỗi chưa chọn nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                staffDAO dao = new staffDAO();
                var p = dao.findStaff(idS);
                if (p.Staff_isActive)
                {
                    MessageBox.Show("Nhân viên vẫn còn làm việc!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn khôi phục nhân viên này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        dao.restoreStaff(idS);
                        MessageBox.Show("Cập nhật thành công!");
                        idS = "";
                        loadData();
                    }
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkEmpty())
            {
                staffDAO dao = new staffDAO();
                if (edit == 1)
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    // thêm mới
                    Staff p = new Staff();
                    p.Staff_Code = txtStaffCode.Text;
                    p.Staff_Name = txtName.Text;
                    p.Staff_Gender = cbbGender.Text;
                    p.Staff_Datebirth = dtpkDatebirth.Value;
                    p.Staff_Phone = txtSDT.Text;
                    p.Staff_Address = txtAddress.Text;
                    p.Staff_Password = "1";
                    p.Staff_isActive= true;
                    p.Staff_isAdmin = false;
                    p.Staff_Image = ImageToBase64(ptImage.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    if (dao.AddStaff(p))
                    {
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Thêm nhân viên thành công!");
                        clear();
                        idS = "";
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
                    Staff p = dao.findStaff(idS);
                    p.Staff_Name = txtName.Text;
                    p.Staff_Gender = cbbGender.Text;
                    p.Staff_Datebirth = dtpkDatebirth.Value;
                    p.Staff_Phone = txtSDT.Text;
                    p.Staff_Address = txtAddress.Text;
                    p.Staff_Image = ImageToBase64(ptImage.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    dao.updateStaff(p);
                    loadData();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Cập nhật thành công!");
                    clear();
                    idS = "";
                    edit = 0;
                    showhideEdit();
                }  
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            idS = "";
            edit = 0;
            showhideEdit();
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcStaff);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void gvListStaff_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idS = gvListStaff.GetFocusedRowCellValue("Staff_ID").ToString();
            txtStaffCode.Text = idS;
            txtName.Text = gvListStaff.GetFocusedRowCellValue("Staff_Name").ToString();
            txtSDT.Text = gvListStaff.GetFocusedRowCellValue("Staff_Phone").ToString();
            txtAddress.Text = gvListStaff.GetFocusedRowCellValue("Staff_Address").ToString();
            ptImage.Image = (Image)gvListStaff.GetFocusedRowCellValue("Staff_Image");
            cbbGender.Text = gvListStaff.GetFocusedRowCellValue("Staff_Gender").ToString();
            if (gvListStaff.GetFocusedRowCellValue("Staff_Datebirth").ToString() == "")
            {
                dtpkDatebirth.Value = DateTime.Now;
            }
            else
            {
                dtpkDatebirth.Value = Convert.ToDateTime(gvListStaff.GetFocusedRowCellValue("Staff_Datebirth").ToString());
            }
        }

        private void Staff_Management_GUI_Load(object sender, EventArgs e)
        {
            showhideEdit();
            loadData();
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
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        void clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtSDT.Clear();
            txtStaffCode.Clear();
            ptImage.Image = DoAnThucTap.Properties.Resources.noimage;
            cbbGender.SelectedIndex = -1;
        }
        void loadData()
        {
            staffDAO dao = new staffDAO();
            List<Staff> list = dao.getFullListStaff();
            List<StaffDTO> listStaff = new List<StaffDTO>();
            if (list.Count>0)
            {
                foreach (var item in list)
                {
                    StaffDTO s = new StaffDTO();
                    s.Staff_ID = item.Staff_Code;
                    s.Staff_Name = item.Staff_Name;
                    if (item.Staff_Gender == null)
                    {
                        s.Staff_Gender = "";
                    }
                    else
                    {
                        s.Staff_Gender = item.Staff_Gender;
                    }
                    if (item.Staff_Datebirth == null)
                    {
                        s.Staff_Datebirth = "";
                    }
                    else
                    {
                        s.Staff_Datebirth = Convert.ToDateTime(item.Staff_Datebirth).ToShortDateString();
                    }
                    if (item.Staff_Phone == null)
                    {
                        s.Staff_Phone = "";
                    }
                    else
                    {
                        s.Staff_Phone = item.Staff_Phone;
                    }
                    if(item.Staff_Address == null)
                    {
                        s.Staff_Address = "";
                    }
                    else
                    {
                        s.Staff_Address = item.Staff_Address;
                    }
                    if (item.Staff_isAdmin == true)
                    {
                        s.Staff_isAdmin = "Quản lý";
                    }
                    else
                    {
                        s.Staff_isAdmin = "Nhân viên";
                    }
                    if (item.Staff_isActive == true)
                    {
                        s.Staff_isActive = "Còn làm việc";
                    }
                    else
                    {
                        s.Staff_isActive = "Ngừng làm việc";
                    }
                    s.Staff_Image = Base64ToImage(item.Staff_Image);
                    listStaff.Add(s);
                }
            }
            gcStaff.DataSource = listStaff;
            gvListStaff.OptionsBehavior.Editable = false;
        }
        bool checkEmpty()
        {
            if (txtStaffCode.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                if (txtName.Text == String.Empty)
                {
                    MessageBox.Show("Không được bỏ trống tên nhân viên!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    DateTime d = dtpkDatebirth.Value;
                    if ((DateTime.Now).Year - d.Year <= 15)
                    {
                        MessageBox.Show("Nhân viên không đủ tuổi!", "Thông tin không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }
            
            return false;
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


    }
}