using Bunifu.UI.WinForms;
using DevExpress.PivotGrid.OLAP.Mdx;
using DevExpress.XtraSplashScreen;
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
            int pid = Convert.ToInt32((sender as BunifuImageButton).Tag);
            DetailProduct_GUI detail = new DetailProduct_GUI(pid);
            detail.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(2);
            SplashScreenManager.CloseForm();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(7);
            SplashScreenManager.CloseForm();
        }

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(1);
            SplashScreenManager.CloseForm();
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(3);
            SplashScreenManager.CloseForm();
        }

        private void btnVitamin_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(4);
            SplashScreenManager.CloseForm();
        }

        private void btnIce_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(6);
            SplashScreenManager.CloseForm();
        }

        private void btnYaour_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(5);
            SplashScreenManager.CloseForm();
        }

        private void btnMoreDrink_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(9);
            SplashScreenManager.CloseForm();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
            loadData(8);
            SplashScreenManager.CloseForm();
        }

        private void btnFind100_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
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
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("Không tìm thấy món bạn cần tìm!");
            }
        }

        private void btnFind50_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tìm món đâyyy...");
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
            SplashScreenManager.CloseForm();
        }
    }
}
