using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using DoAnThucTap.userControl;
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
    public partial class Recipe_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        private int pid = 0;
        private int id = 0;
        private int CountStep = 0;
        private int edit = 0;
        public Recipe_Management_GUI()
        {
            InitializeComponent();
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
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            edit = 1;
            showhideEdit();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn một món bất kỳ!", "Lỗi chưa chọn món", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clear();
                edit = 2;
                showhideEdit();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            pid = 0;
            edit = 0;
            showhideEdit();
        }

        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcRecipe);
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

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Recipe_Management_GUI_Load(object sender, EventArgs e)
        {
            loadData();
            loadCombobox();
        }
        void loadCombobox()
        {
            cbbChooseProduct.Items.Clear();
            menuDAO dao = new menuDAO();
            List<Product> products = dao.getFullListMenu();
            foreach (var item in products)
            {
                cbbChooseProduct.Items.Add(item.Product_Name);
            }
        }
        void loadData()
        {
            menuDAO dao = new menuDAO();
            List<Recipe> recipes = dao.getfullListRecipe();
            List<recipeDTO> recipeDTOs = new List<recipeDTO>();
            foreach (var item in recipes)
            {
                recipeDTO dto = new recipeDTO();
                dto.Recipe_ID = item.Recipe_ID;
                dto.Recipe_Info = item.Recipe_Info;
                dto.Recipe_Product = dao.getProductbyID(item.Recipe_Product).Product_Name;
                recipeDTOs.Add(dto);
            }
            gcRecipe.DataSource= recipeDTOs;
            gvListRecipe.OptionsBehavior.Editable = false;
        }
        void clear()
        {
            flpRecipe.Controls.Clear();
            CountStep = 0;
            pid = 0;
            cbbChooseProduct.SelectedIndex = -1;
            nbrQuantity.Value = 1;
        }
        void loadStep()
        {
            if (flpRecipe.Controls.Count > 0)
            {
                if(CountStep> flpRecipe.Controls.Count)
                {
                    int s = flpRecipe.Controls.Count+1;
                    for (int i = s; i <= CountStep; i++)
                    {
                        item_Recipe recipe = new item_Recipe();
                        recipe.getStep = i;
                        flpRecipe.Controls.Add(recipe);
                    }
                }
                else
                {
                    int countDelete =  flpRecipe.Controls.Count - CountStep;
                    int start = flpRecipe.Controls.Count - 1;
                    for (int i = start; i >= CountStep; i--)
                    {
                        flpRecipe.Controls.RemoveAt(i);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= CountStep; i++)
                {
                    item_Recipe recipe = new item_Recipe();
                    recipe.getStep = i;
                    flpRecipe.Controls.Add(recipe);
                }
            }
        }
        private void btnAcceptProduct_Click(object sender, EventArgs e)
        {
            if (cbbChooseProduct.Text == "")
            {
                MessageBox.Show("Vui lòng chọn món trước khi nhấn xác nhận!", "Chờ đã!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                menuDAO dao = new menuDAO();
                var p = dao.searchbyName(cbbChooseProduct.Text);
                pid = p.Product_ID;
                CountStep = (int)nbrQuantity.Value;
                loadStep();
            }
        }

        private void gvListRecipe_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            menuDAO dao = new menuDAO();
            id = dao.searchbyName(gvListRecipe.GetFocusedRowCellValue("Recipe_Product").ToString()).Product_ID;
        }
    }
}