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
    public partial class ApplyDiscountForMenu_GUI : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        private List<int> listproduct = new List<int>();
        private int disID;
        public ApplyDiscountForMenu_GUI(int DiscountID)
        {
            InitializeComponent();
            this.disID = DiscountID;
            loadData();
        }

        private void gcApplyDiscount_Click(object sender, EventArgs e)
        {

        }

        void loadData()
        {
            checkGrid();
            menuDAO dao = new menuDAO();
            List<Product> listmenu  = dao.getFullListMenu();
            List<ApplyDiscountDTO> listdto = new List<ApplyDiscountDTO>();
            if (listmenu.Count > 0)
            {
                foreach (var item in listmenu)
                {
                    ApplyDiscountDTO dto = new ApplyDiscountDTO();
                    dto.Product_ID = item.Product_ID;
                    dto.Product_Name = item.Product_Name;
                    dto.Product_Unit = item.Product_Unit;
                    dto.Product_Price = item.Product_Price;
                    listdto.Add(dto);
                }
            }
            gcApplyDiscount.DataSource = listdto;
            gvApplyDiscount.OptionsBehavior.Editable = false;
            checkData();
        }
        void checkData()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<getListDiscount_Result> list = db.getListDiscount(this.disID).ToList();
                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        for (int i = 0; i < gvApplyDiscount.RowCount; i++)
                        {
                            if (Convert.ToInt32(gvApplyDiscount.GetRowCellValue(i,"Product_ID"))==item.Discount_Product)
                            {
                                gvApplyDiscount.SelectRow(i);
                            }
                        }
                    }
                }
            }
        }
        private void gvApplyDiscount_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //if()
        }

        void checkGrid()
        {
            gvApplyDiscount.OptionsSelection.MultiSelect= true;
            gvApplyDiscount.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gvApplyDiscount.RowCount; i++)
            {
                if (gvApplyDiscount.IsRowSelected(i))
                {
                    int pid = Convert.ToInt32(gvApplyDiscount.GetRowCellValue(i, "Product_ID"));
                    listproduct.Add(pid);
                }
            }
            updateData();
        }
        void updateData()
        {
            try
            {
                using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
                {
                    db.deleteDiscountApply(disID);
                    if (listproduct.Count > 0)
                    {
                        foreach (var item in listproduct)
                        {
                            db.addDiscountApply(disID, item);
                        }
                    }
                    MessageBox.Show("Cập nhật thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Xin lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}