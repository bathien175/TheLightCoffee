using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
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
using static Bunifu.UI.WinForms.BunifuButton.BunifuButton;

namespace DoAnThucTap.GUI
{
    public partial class Product_GUI : Form
    {
        public Product_GUI()
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            InitializeComponent();
            loadSource();
            loadCategory();
            SplashScreenManager.CloseForm();
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
        public void loadData(int cate)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
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
                pro.Width = pnlListProduct.Width;
                pnlListProduct.Controls.Add(pro);
                stt++;
            }
            SplashScreenManager.CloseForm();
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
        #region loadGenre
        Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
        BunifuButton createNewBunifuBtn(String txt)
        {
            BunifuButton btnTea = new BunifuButton();
            btnTea.AllowAnimations = true;
            btnTea.AllowMouseEffects = true;
            btnTea.AllowToggling = false;
            btnTea.AnimationSpeed = 200;
            btnTea.AutoGenerateColors = false;
            btnTea.AutoRoundBorders = false;
            btnTea.AutoSizeLeftIcon = true;
            btnTea.AutoSizeRightIcon = true;
            btnTea.BackColor = System.Drawing.Color.Transparent;
            btnTea.BackColor1 = System.Drawing.Color.Teal;
            //this.btnTea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTea.BackgroundImage")));
            btnTea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnTea.ButtonText = txt;
            btnTea.ButtonTextMarginLeft = 0;
            btnTea.ColorContrastOnClick = 45;
            btnTea.ColorContrastOnHover = 45;
            btnTea.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            btnTea.CustomizableEdges = borderEdges10;
            btnTea.DialogResult = System.Windows.Forms.DialogResult.None;
            btnTea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            btnTea.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            btnTea.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            btnTea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnTea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTea.ForeColor = System.Drawing.Color.White;
            btnTea.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTea.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            btnTea.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            btnTea.IconMarginLeft = 11;
            btnTea.IconPadding = 10;
            btnTea.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnTea.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            btnTea.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            btnTea.IconSize = 25;
            btnTea.IdleBorderColor = System.Drawing.Color.Azure;
            btnTea.IdleBorderRadius = 10;
            btnTea.IdleBorderThickness = 1;
            btnTea.IdleFillColor = System.Drawing.Color.Teal;
            btnTea.IdleIconLeftImage = null;
            btnTea.IdleIconRightImage = null;
            btnTea.IndicateFocus = false;
            btnTea.Location = new System.Drawing.Point(8, 8);
            btnTea.Name = "btnTea";
            btnTea.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            btnTea.OnDisabledState.BorderRadius = 10;
            btnTea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnTea.OnDisabledState.BorderThickness = 1;
            btnTea.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            btnTea.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            btnTea.OnDisabledState.IconLeftImage = null;
            btnTea.OnDisabledState.IconRightImage = null;
            btnTea.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            btnTea.onHoverState.BorderRadius = 10;
            btnTea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnTea.onHoverState.BorderThickness = 1;
            btnTea.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            btnTea.onHoverState.ForeColor = System.Drawing.Color.White;
            btnTea.onHoverState.IconLeftImage = null;
            btnTea.onHoverState.IconRightImage = null;
            btnTea.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            btnTea.OnIdleState.BorderRadius = 10;
            btnTea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnTea.OnIdleState.BorderThickness = 1;
            btnTea.OnIdleState.FillColor = System.Drawing.Color.Teal;
            btnTea.OnIdleState.ForeColor = System.Drawing.Color.White;
            btnTea.OnIdleState.IconLeftImage = null;
            btnTea.OnIdleState.IconRightImage = null;
            btnTea.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            btnTea.OnPressedState.BorderRadius = 10;
            btnTea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnTea.OnPressedState.BorderThickness = 1;
            btnTea.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            btnTea.OnPressedState.ForeColor = System.Drawing.Color.White;
            btnTea.OnPressedState.IconLeftImage = null;
            btnTea.OnPressedState.IconRightImage = null;
            btnTea.Size = new System.Drawing.Size(193, 49);
            btnTea.TabIndex = 0;
            btnTea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnTea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            btnTea.TextMarginLeft = 0;
            btnTea.TextPadding = new System.Windows.Forms.Padding(0);
            btnTea.UseDefaultRadiusAndThickness = true;
            //this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            return btnTea;
        }
        private void btnGenre_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32((sender as BunifuButton).Tag);
            loadData(t);
        }
        void loadCategory()
        {
            flpCategory.Controls.Clear();
            menuDAO dao = new menuDAO();
            List<Category> listcate = dao.getListCategory();
            if (listcate.Count > 0)
            {
                BunifuButton btnAll = createNewBunifuBtn("Tất cả");
                btnAll.Tag = 0;
                btnAll.Click += btnGenre_Click;
                flpCategory.Controls.Add(btnAll);
                foreach (var item in listcate)
                {
                    BunifuButton btn = createNewBunifuBtn(item.Category_Name);
                    btn.Tag = item.Category_ID;
                    btn.Click += btnGenre_Click;
                    flpCategory.Controls.Add(btn);
                }
            }
        }
        #endregion
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
                pro.Width = pnlListProduct.Width;
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
                    pro.Width = pnlListProduct.Width;
                    pnlListProduct.Controls.Add(pro);
                    stt++;
                }
            }
            SplashScreenManager.CloseForm();
        }
    }
}
