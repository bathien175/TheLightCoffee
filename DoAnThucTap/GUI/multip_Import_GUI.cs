using Bunifu.UI.WinForms;
using DevExpress.PivotGrid.OLAP.Mdx;
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
using System.Web.Services.Description;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class multip_Import_GUI : Form
    {
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
            foreach (var item in tbImport.Controls)
            {
                item_Import im = (item_Import)item;
                if (im.getSetID == i.Ingredient_ID)
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
                if (tbImport.Controls.Count > 0)
                {
                    if (checkImportList(x)) //;tồn tại sẵn món
                    {
                        foreach (var item in tbImport.Controls) //duyệt list cũ
                        {
                            item_Import im = (item_Import)item;
                            if (im.getSetID == x.Ingredient_ID) // nếu tìm đc thì cập nhạt số lượng
                            {
                                im.getSetSL += Convert.ToDouble(nbrSL.Value);
                            }
                            else
                            {
                                //còn không đúng thì next
                            }
                        }
                    }
                    else // chưa tồn tại thì add
                    {
                        item_Import d = new item_Import();
                        d.getSetID= x.Ingredient_ID;
                        d.getSetName = x.Ingredient_Name;
                        d.getSetImage = x.Ingredient_Image;
                        d.getSetPrice = x.Ingredient_PriceImport;
                        d.getSetSL = Convert.ToDouble(nbrSL.Value);
                        double check = Math.Ceiling(Math.Round((Convert.ToDouble(d.getSetPrice * d.getSetSL) / 1000), 1));
                        d.getSetTotal = Convert.ToInt64(check * 1000);
                        BunifuImageButton btnSub = d.getbtnSub();
                        BunifuImageButton btnDel = d.getbtnDel();
                        btnSub.Tag = x.Ingredient_ID;
                        btnDel.Tag = x.Ingredient_ID;
                        btnSub.Click += BtnSub_Click;
                        btnDel.Click += BtnDel_Click;
                        d.Width = tbImport.Width;
                        tbImport.Controls.Add(d);
                    }
                }
                else // ngược lại list rỗng thì cũng add thẳng
                {
                    item_Import d = new item_Import();
                    d.getSetID = x.Ingredient_ID;
                    d.getSetName = x.Ingredient_Name;
                    d.getSetImage = x.Ingredient_Image;
                    d.getSetPrice = x.Ingredient_PriceImport;
                    d.getSetSL = Convert.ToDouble(nbrSL.Value);
                    double check = Math.Ceiling(Math.Round((Convert.ToDouble(d.getSetPrice * d.getSetSL) / 1000), 1));
                    d.getSetTotal = Convert.ToInt64(check * 1000);
                    BunifuImageButton btnSub = d.getbtnSub();
                    BunifuImageButton btnDel = d.getbtnDel();
                    btnSub.Tag = x.Ingredient_ID;
                    btnDel.Tag = x.Ingredient_ID;
                    btnSub.Click += BtnSub_Click;
                    btnDel.Click += BtnDel_Click;
                    d.Width = tbImport.Width;
                    tbImport.Controls.Add(d);
                }
                nbrSL.Value = 1;
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as BunifuImageButton).Tag);
            List<detailImport> list2 = new List<detailImport>();
            for (int i = 0; i < tbImport.Controls.Count;i++)
            {
                item_Import im = (item_Import)tbImport.Controls[i];
                if (im.getSetID == id)
                {
                    tbImport.Controls.RemoveAt(i);
                }
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as BunifuImageButton).Tag);
            List<detailImport> list2 = new List<detailImport>();
            for (int i = 0; i < tbImport.Controls.Count; i++)
            {
                item_Import im = (item_Import)tbImport.Controls[i];
                if (im.getSetID == id)
                {
                    if (im.getSetSL > 1)
                    {
                        im.getSetSL -= 1;
                    }
                    else
                    {
                        tbImport.Controls.RemoveAt(i);
                    }
                }
            }
        }
        private int checkMoney()
        {
            int s = 0;
            foreach (var item in tbImport.Controls)
            {
                item_Import i = (item_Import)item;
                int test = Convert.ToInt32(i.getSetPrice % 1000);
                if (test != 5 && test != 0)
                {
                    i.errorMoney(true);
                    s++;
                }
                else
                {
                    i.errorMoney(false);
                }
            }
            return s;
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (tbImport.Controls.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn một nguyên liệu nào!", "Lỗi nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkMoney() == 0) // kiểm tra lỗi tiền
                {
                    // nhập nhiều
                    IngredientDAO dao = new IngredientDAO();
                    try
                    {
                        List<detailImport> listimport = new List<detailImport>();
                        foreach (var item in tbImport.Controls)
                        {
                            item_Import im = (item_Import)item;
                            detailImport dto = new detailImport();
                            dto.ingredient = new IngredientDAO().getIngredientbyID(im.getSetID);
                            dto.sl = im.getSetSL;
                            dto.Price = im.getSetPrice;
                            listimport.Add(dto);
                        }
                        List<exportIImport_Result> data = dao.ImportMultip(staffcode, listimport);
                        if (data.Count > 0)
                        {
                            printImport print = new printImport();
                            print.Print(data);
                            print.ShowDialog();
                            tbImport.Controls.Clear();
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
                else
                {
                    MessageBox.Show("Tiền nhập không hợp lệ! Vui lòng kiểm tra và thử lại!", "Lỗi nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
