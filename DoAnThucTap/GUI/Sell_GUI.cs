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
        private DBTable tablecurrent = new DBTable();
        private Bill billcurrent = new Bill();
        private Staff staff= new Staff();
        public Sell_GUI(string tbCode,Staff s)
        {
            InitializeComponent();
            if (tbCode == "TakeAway")
            {
                lblData.Text = "Bán mang về";
                tablecurrent = null;
            }
            else
            {
                tablecurrent = new tableDAO().getTableByID(tbCode);
                lblData.Text = tablecurrent.Table_Location + " - Bàn " + tablecurrent.Table_Code;
            }
            this.staff = s;
            loadBill();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (billcurrent != null)
            {
                if (billcurrent.Bill_isTakeAway == true)
                {
                    billDAO dao = new billDAO();
                    dao.CancelBillTakeAway();
                }
            }
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
        void loadBill() // đảm nhận vai trò load dữ liệu lên bảng hóa đơn tạm
        {
            Bill.Controls.Clear();
            billDAO dao = new billDAO();
            DTO.Bill b = new DTO.Bill();
            if (tablecurrent == null)
            {
                //takeAway
                b = dao.getTakeAwayCurrent();
            }
            else
            {
                //at store
                 b = dao.getBillbyTableID(tablecurrent.Table_Code);
            }
            billcurrent = b;
            if (b != null)
            {
                List<Bill_Info> list =  dao.getListBillInfo(b.Bill_ID);
                if (list.Count > 0)
                {
                    foreach (Bill_Info item in list)
                    {
                        itemBill i = new itemBill();
                        i.productid = item.BI_Product;
                        i.nameMenu = new menuDAO().getProductbyID(item.BI_Product).Product_Name;
                        i.slMenu = item.BI_Quantity;
                        i.btnDel().Tag = item.BI_Product;
                        i.btnDel().Click += deleteItemBill_Click;
                        itemBillList.Add(i);
                        Bill.Controls.Add(i);
                    }
                }
            }
        }

        private void deleteItemBill_Click(object sender, EventArgs e)
        {
            //List<itemBill> list = new List<itemBill>();
            //foreach (itemBill item in itemBillList)
            //{
            //    if(item.productid!=Convert.ToInt32((sender as BunifuImageButton).Tag))
            //    {
            //        list.Add(item);
            //    }
            //}
            //itemBillList = list;
            //loadBill();
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            Product p = (sender as PictureBox).Tag as Product;
            addToBill_GUI add = new addToBill_GUI(p,staff,tablecurrent);
            this.Opacity = 0.93;
            add.ShowDialog();
            this.Opacity = 1;
            loadBill();
            //itemBill b = new itemBill();
            //Product p = (sender as PictureBox).Tag as Product;
            //b.nameMenu = p.Product_Name;
            //b.slMenu = 1;
            //b.productid= p.Product_ID;
            //if (itemBillList.Count == 0)
            //{
            //    itemBillList.Add(b);
            //}
            //else
            //{
            //    List<itemBill> list = new List<itemBill>();
            //    bool existMenu = false;
            //    foreach (itemBill item in itemBillList)
            //    {
            //        if (b.productid == item.productid)
            //        {
            //            item.slMenu += 1;
            //            list.Add(item);
            //            existMenu = true;
            //        }
            //        else
            //        {
            //            list.Add(item);
            //        }
            //    }
            //    if (existMenu == false)
            //    {
            //        list.Add(b);
            //    }
            //    itemBillList = list;
            //}
            //loadBill();
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (billcurrent.Bill_isTakeAway == true)
            {
                MessageBox.Show("Hóa đơn mang về");
                printBill_GUI print = new printBill_GUI(billcurrent.Bill_ID);
                print.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hóa đơn tại chỗ");
            }
        }
    }
}
