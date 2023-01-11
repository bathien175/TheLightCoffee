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
using System.Xml.Linq;

namespace DoAnThucTap.GUI
{
    public partial class Table_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Table_Management_GUI()
        {
            InitializeComponent();
            loadData();
            showhideEdit();
        }
        String idI = "";
        int edit = 0;

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            edit = 1;
            showhideEdit();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn cần chỉnh sửa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn bàn!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                edit = 2;
                showhideEdit();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn bàn!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code xóa bàn
                tableDAO dao = new tableDAO();
                var p = dao.getTableByID(idI);
                if (p.isActive==false)
                {
                    MessageBox.Show("Bàn này đã được ngưng sử dụng từ trước đó!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn ngưng sử dụng bàn này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.deleteTable(idI);
                        idI = "";
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Xóa bàn thành công!");
                    }
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idI == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn cần xóa! Vui lòng chọn và thử lại!", "Lỗi chưa chọn bàn!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //code khôi phục bàn
                tableDAO dao = new tableDAO();
                var p = dao.getTableByID(idI);
                if (p.isActive == true)
                {
                    MessageBox.Show("Bàn này vẫn còn đang được sử dụng! Hãy thử với bàn khác!", "Lỗi trạng thái!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult sl = MessageBox.Show("Bạn có chắc chắn muốn sử dụng lại bàn này chứ?", "Chờ đã", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sl == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.restoreTable(idI);
                        idI = "";
                        loadData();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Khôi phục bàn thành công!");
                    }
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkEmpty())
            {
                tableDAO dao = new tableDAO();
                if (edit == 1)
                {
                    // thêm mới
                    DBTable p = new DBTable();
                    p.Table_Code = txtTableCode.Text;
                    p.Table_Location = cbbLocation.Text;
                    p.Table_Status = 0;
                    p.isActive= true;
                    bool i = dao.checkExistCode(p.Table_Code);
                    if (i)
                    {
                        MessageBox.Show("Mã bàn đã tồn tại! Vui lòng kiểm tra và thử lại!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                        SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                        dao.addTable(p);
                        loadData();
                        clear();
                        idI = "";
                        edit = 0;
                        showhideEdit();
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Thêm bàn thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                    //sửa món
                    DBTable t = dao.getTableByID(idI);
                    t.Table_Location = cbbLocation.Text;
                    dao.updateTable(t);
                    loadData();
                    clear();
                    idI = "";
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
            idI = "";
            edit = 0;
            showhideEdit();
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcTable);
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
                txtTableCode.Enabled = false;
                cbbLocation.Enabled = false;
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
                    txtTableCode.Enabled = false;
                }
                else
                {
                    txtTableCode.Enabled = true;
                }
                cbbLocation.Enabled = true;
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
            tableDAO dao = new tableDAO();
            List<DBTable> list = dao.getFullListTable();
            List<DBTableDTO> dBTableDTOs = new List<DBTableDTO>();
            foreach (var item in list)
            {
                DBTableDTO dto = new DBTableDTO();
                dto.Table_Code = item.Table_Code;
                dto.Table_Location = item.Table_Location;
                if (item.Table_Status == 0)
                {
                    dto.Table_Status = "Trống";
                }
                else if (item.Table_Status == 1)
                {
                    dto.Table_Status = "Có khách";
                }
                else
                {
                    dto.Table_Status = "Đặt trước";
                }
                if (item.isActive == true)
                {
                    dto.Table_isActive = "Đang sử dụng";
                }
                else
                {
                    dto.Table_isActive = "Ngừng sử dụng";
                }
                dBTableDTOs.Add(dto);
            }
            gcTable.DataSource = dBTableDTOs;
            gvListTable.OptionsBehavior.Editable = false;
        }
        void clear()
        {
            txtTableCode.Clear();
            cbbLocation.SelectedIndex = 0;
        }
        bool checkEmpty()
        {
            if (txtTableCode.Text == String.Empty)
            {
                MessageBox.Show("Không được bỏ trống thông tin nào!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                if (cbbLocation.Text==String.Empty)
                {
                    MessageBox.Show("Không được bỏ trống thông tin nào!", "Vui lòng điền đầy đủ thông tin cần thiết!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        private void gvListTable_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            idI = gvListTable.GetFocusedRowCellValue("Table_Code").ToString();
            cbbLocation.Text = gvListTable.GetFocusedRowCellValue("Table_Location").ToString();
            txtTableCode.Text = idI;
        }
    }
}