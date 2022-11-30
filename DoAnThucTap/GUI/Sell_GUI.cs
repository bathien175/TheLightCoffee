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
using DoAnThucTap.Properties;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using Bunifu.UI.WinForms;

namespace DoAnThucTap.GUI
{
    public partial class Sell_GUI : Form
    {
        private List<itemBill> itemBillList = new List<itemBill>();
        public Sell_GUI()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sell_GUI_Load(object sender, EventArgs e)
        {
            loadMenu(0);
        }
        private void loadMenu(int cate)
        {
            tbMenu.Controls.Clear();
            if (cate == 0)
            {
                menuDAO dao = new menuDAO();
                List<Product> products = dao.getListMenu();
                AutoCompleteStringCollection nameproductList = new AutoCompleteStringCollection();
                if (products.Count > 0)
                {
                    foreach (Product item in products)
                    {
                        itemMenu menu = new itemMenu();
                        menu.nameMenu = item.Product_Name;
                        menu.priceMenu = String.Format("{0:0,0 vnđ}", item.Product_Price);
                        menu.imageProduct = Image.FromFile(@"../../ImageProduct/" + item.Product_Image);
                        menu.productid= item.Product_ID;
                        PictureBox i = menu.getpicture();
                        i.Tag = item;
                        i.Click += addMenu_Click;
                        nameproductList.Add(item.Product_Name);
                        tbMenu.Controls.Add(menu);
                    }
                }
                txtSearch.AutoCompleteCustomSource = nameproductList;
            }
            else
            {
                menuDAO dao = new menuDAO();
                List<Product> products = dao.getListMenubyGenre(cate);
                if (products.Count > 0)
                {
                    foreach (Product item in products)
                    {
                        itemMenu menu = new itemMenu();
                        menu.nameMenu = item.Product_Name;
                        menu.priceMenu = String.Format("{0:0,0 vnđ}", item.Product_Price);
                        menu.imageProduct = Image.FromFile(@"../../ImageProduct/" + item.Product_Image);
                        menu.productid = item.Product_ID;
                        PictureBox i = menu.getpicture();
                        i.Tag = item;
                        i.Click += addMenu_Click;
                        tbMenu.Controls.Add(menu);
                    }
                }
            }
        }
        void loadBill()
        {
            Bill.Controls.Clear();
            if (itemBillList.Count > 0)
            {
                foreach (itemBill item in itemBillList)
                {
                    item.btnDel().Tag = item.productid;
                    item.btnDel().Click += deleteItemBill_Click;
                    Bill.Controls.Add(item);
                }
            }
        }

        private void deleteItemBill_Click(object sender, EventArgs e)
        {
            List<itemBill> list = new List<itemBill>();
            foreach (itemBill item in itemBillList)
            {
                if(item.productid!=Convert.ToInt32((sender as BunifuImageButton).Tag))
                {
                    list.Add(item);
                }
            }
            itemBillList = list;
            loadBill();
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            itemBill b = new itemBill();
            Product p = (sender as PictureBox).Tag as Product;
            b.nameMenu = p.Product_Name;
            b.slMenu = 1;
            b.productid= p.Product_ID;
            if (itemBillList.Count == 0)
            {
                itemBillList.Add(b);
            }
            else
            {
                List<itemBill> list = new List<itemBill>();
                bool existMenu = false;
                foreach (itemBill item in itemBillList)
                {
                    if (b.productid == item.productid)
                    {
                        item.slMenu += 1;
                        list.Add(item);
                        existMenu = true;
                    }
                    else
                    {
                        list.Add(item);
                    }
                }
                if (existMenu == false)
                {
                    list.Add(b);
                }
                itemBillList = list;
            }
            loadBill();
        }

        #region clickGenre
        private void btnTea_Click(object sender, EventArgs e)
        {
            loadMenu(2);
            txtSearch.Clear();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            loadMenu(7);
            txtSearch.Clear();
        }

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            loadMenu(1);
            txtSearch.Clear();
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            loadMenu(3);
            txtSearch.Clear();
        }

        private void btnVitamin_Click(object sender, EventArgs e)
        {
            loadMenu(4);
            txtSearch.Clear();
        }

        private void btnIce_Click(object sender, EventArgs e)
        {
            loadMenu(6);
            txtSearch.Clear();
        }

        private void btnYaour_Click(object sender, EventArgs e)
        {
            loadMenu(5);
            txtSearch.Clear();
        }

        private void btnMoreDrink_Click(object sender, EventArgs e)
        {
            loadMenu(9);
            txtSearch.Clear();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            loadMenu(8);
            txtSearch.Clear();
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            menuDAO dao = new menuDAO();
            var product = dao.searchbyName(txtSearch.Text);
            if(product != null)
            {
                tbMenu.Controls.Clear();
                itemMenu menu = new itemMenu();
                menu.nameMenu = product.Product_Name;
                menu.priceMenu = String.Format("{0:0,0 vnđ}", product.Product_Price);
                menu.imageProduct = Image.FromFile(@"../../ImageProduct/" + product.Product_Image);
                menu.productid = product.Product_ID;
                PictureBox i = menu.getpicture();
                i.Tag = product;
                i.Click += addMenu_Click;
                tbMenu.Controls.Add(menu);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm trùng khớp!", "Lỗi tìm kiếm!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
