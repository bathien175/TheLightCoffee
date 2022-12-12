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
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class Product_GUI : Form
    {
        public Product_GUI()
        {
            InitializeComponent();
            loadSource();
            loadData(0);
        }
        void loadSource()
        {
            menuDAO dao = new menuDAO();
            List<Product> list = dao.getListMenu();
            AutoCompleteStringCollection listString = new AutoCompleteStringCollection();
            foreach (Product item in list)
            {
                listString.Add(item.Product_Name);
            }
            txtFind100.AutoCompleteCustomSource = listString;
        }
        void loadData(int cate)
        {
            pnlListProduct.Controls.Clear();
            menuDAO dao = new menuDAO();
            List<Product> list = new List<Product>();
            if (cate == 0)
            {
                list = dao.getListMenu();
            }
            else
            {
                list = dao.getListMenubyGenre(cate);
            }
            int stt = 1;
            foreach (Product item in list)
            {
                item_Product pro = new item_Product();
                pro.idProduct = stt;
                pro.nameProduct = item.Product_Name;
                pro.cateNameProduct = dao.GetCategory(item.Product_Category).Category_Name;
                pro.unitProduct = item.Product_Unit;
                pro.priceProduct = item.Product_Price;
                pro.imageProduct = item.Product_Image;
                BunifuImageButton btn = pro.detailButton;
                btn.Tag = item.Product_ID;
                btn.Click += BtnDetail_Click;
                pnlListProduct.Controls.Add(pro);
                stt++;
            }
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            loadData(7);
        }

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            loadData(1);
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            loadData(3);
        }

        private void btnVitamin_Click(object sender, EventArgs e)
        {
            loadData(4);
        }

        private void btnIce_Click(object sender, EventArgs e)
        {
            loadData(6);
        }

        private void btnYaour_Click(object sender, EventArgs e)
        {
            loadData(5);
        }

        private void btnMoreDrink_Click(object sender, EventArgs e)
        {
            loadData(9);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            loadData(8);
        }

        private void btnFind100_Click(object sender, EventArgs e)
        {
            menuDAO dao = new menuDAO();
            var p = dao.searchbyName(txtFind100.Text);
            if (p != null)
            {
                pnlListProduct.Controls.Clear();
                item_Product pro = new item_Product();
                pro.idProduct = 1;
                pro.nameProduct = p.Product_Name;
                pro.cateNameProduct = dao.GetCategory(p.Product_Category).Category_Name;
                pro.unitProduct = p.Product_Unit;
                pro.priceProduct = p.Product_Price;
                pro.imageProduct = p.Product_Image;
                BunifuImageButton btn = pro.detailButton;
                btn.Tag = p.Product_ID;
                btn.Click += BtnDetail_Click;
                pnlListProduct.Controls.Add(pro);
            }
            else
            {
                MessageBox.Show("Không tìm thấy món bạn cần tìm!");
            }
        }

        private void btnFind50_Click(object sender, EventArgs e)
        {
            pnlListProduct.Controls.Clear();
            menuDAO dao = new menuDAO();
            List<Product> list = dao.find50(txtFind50.Text);
            if (list.Count > 0)
            {
                int stt = 1;
                foreach (Product item in list)
                {
                    item_Product pro = new item_Product();
                    pro.idProduct = stt;
                    pro.nameProduct = item.Product_Name;
                    pro.cateNameProduct = dao.GetCategory(item.Product_Category).Category_Name;
                    pro.unitProduct = item.Product_Unit;
                    pro.priceProduct = item.Product_Price;
                    pro.imageProduct = item.Product_Image;
                    BunifuImageButton btn = pro.detailButton;
                    btn.Tag = item.Product_ID;
                    btn.Click += BtnDetail_Click;
                    pnlListProduct.Controls.Add(pro);
                    stt++;
                }
            }
        }
    }
}
