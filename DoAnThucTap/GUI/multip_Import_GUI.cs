using Bunifu.UI.WinForms;
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

namespace DoAnThucTap.GUI
{
    public partial class multip_Import_GUI : Form
    {
        private List<detailImport> listimport = new List<detailImport>();
        private String staffcode;
        public multip_Import_GUI(string staffID)
        {
            InitializeComponent();
            loadData();
            this.staffcode = staffID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        void loadData()
        {
            IngredientDAO dao = new IngredientDAO();
            List<Ingredient> list = dao.getFullIngredient();
            foreach (var item in list)
            {
                cbbIngredient.Items.Add(item.Ingredient_Name);
            }
        }
        bool checkImportList(Ingredient i)
        {
            foreach (var item in listimport)
            {
                if (item.ingredient.Ingredient_ID == i.Ingredient_ID)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbIngredient.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu để nhập!", "Đã có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IngredientDAO dao = new IngredientDAO();
                var x = dao.searchByName(cbbIngredient.Text);
                if (listimport.Count > 0)
                {
                    if (checkImportList(x))
                    {
                        List<detailImport> list2 = new List<detailImport>();
                        foreach (var item in listimport)
                        {
                            if (item.ingredient.Ingredient_ID == x.Ingredient_ID)
                            {
                                item.sl += Convert.ToInt32(nbrSL.Value);
                                list2.Add(item);
                            }
                            else
                            {
                                list2.Add(item);
                            }
                        }
                        listimport = list2;
                    }
                    else
                    {
                        detailImport d = new detailImport();
                        d.sl = Convert.ToInt32(nbrSL.Value);
                        d.ingredient = x;
                        listimport.Add(d);
                    }
                }
                else
                {
                    detailImport d = new detailImport();
                    d.sl = Convert.ToInt32(nbrSL.Value);
                    d.ingredient = x;
                    listimport.Add(d);
                }
                nbrSL.Value = 1;
                loadTable();
            }
        }

        private void loadTable()
        {
            tbImport.Controls.Clear();
            int stt = 1;
            foreach (var item in listimport)
            {
                item_Import i = new item_Import();
                i.getSetID = stt;
                i.getSetName = item.ingredient.Ingredient_Name;
                i.getSetPrice = item.ingredient.Ingredient_PriceImport;
                i.getSetUnit = item.ingredient.Ingredient_Unit;
                i.getSetImage = item.ingredient.Ingredient_Image;
                i.getSetSL = item.sl;
                BunifuImageButton btnSub = i.getbtnSub();
                BunifuImageButton btnDel = i.getbtnDel();
                btnSub.Tag = item.ingredient.Ingredient_ID;
                btnDel.Tag = item.ingredient.Ingredient_ID;
                btnSub.Click += BtnSub_Click;
                btnDel.Click += BtnDel_Click;
                stt++;
                tbImport.Controls.Add(i);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as BunifuImageButton).Tag);
            List<detailImport> list2 = new List<detailImport>();
            foreach (var item in listimport)
            {
                if (item.ingredient.Ingredient_ID != id)
                {
                    list2.Add(item);
                }
            }
            listimport = list2;
            loadTable();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as BunifuImageButton).Tag);
            List<detailImport> list2 = new List<detailImport>();
            foreach (var item in listimport)
            {
                if (item.ingredient.Ingredient_ID == id)
                {
                    if (item.sl > 1)
                    {
                        item.sl--;
                        list2.Add(item);
                    }
                }
                else
                {
                    list2.Add(item);
                }
            }
            listimport = list2;
            loadTable();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (listimport.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn một nguyên liệu nào!", "Lỗi nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // nhập nhiều
                IngredientDAO dao = new IngredientDAO();
                try
                {
                    List<exportIImport_Result> data = dao.ImportMultip(staffcode, listimport);
                    if(data.Count > 0) 
                    {
                        printImport print = new printImport();
                        print.Print(data);
                        print.ShowDialog();
                        listimport.Clear();
                        loadTable();
                    }
                    else
                    {
                        MessageBox.Show("Tiền nhập hàng lớn hơn ngân sách hiện có!", "Lỗi nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra và thử lại sau!");
                }
            }
        }
    }
}
