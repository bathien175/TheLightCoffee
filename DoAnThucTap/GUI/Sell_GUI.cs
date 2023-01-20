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
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Encoders;
using System.Drawing.Imaging;
using System.IO;
using Bunifu.UI.WinForms.BunifuButton;
using MetroFramework.Properties;
using static Bunifu.UI.WinForms.BunifuButton.BunifuButton;
using DevExpress.Office.Services;
using DevExpress.XtraSplashScreen;

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
            loadCategory();
            loadBill();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (billcurrent != null)
            {
                if (billcurrent.Bill_isTakeAway == true)
                {
                    billDAO dao = new billDAO();
                    var t = dao.getBill(billcurrent.Bill_ID);
                    billcurrent = t;
                    if (t.Bill_Status == false)
                    {
                        dao.CancelBillTakeAway();
                    }
                }
            }
            this.Close();
        }
        public byte[] ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes,0,imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms,true);
            return image;
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
                        menu.imageProduct = Base64ToImage(item.Product_Image);
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
                        menu.imageProduct = Base64ToImage(item.Product_Image);
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
                        Bunifu.UI.WinForms.BunifuImageButton btndel = i.btnDel();
                        Bunifu.UI.WinForms.BunifuImageButton btnsub = i.btnSubtract();
                        btndel.Tag= item.BI_Product;
                        btnsub.Tag= item.BI_Product;
                        btndel.Click += deleteItemBill_Click;
                        btnsub.Click += subItemBill_Click;
                        itemBillList.Add(i);
                        Bill.Controls.Add(i);
                    }
                }
            }
        }

        private void subItemBill_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32((sender as BunifuImageButton).Tag);
            billDAO dao  =new billDAO();
            dao.editQuantityBillinfo(billcurrent.Bill_ID, pid);
            loadBill();
        }

        private void deleteItemBill_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32((sender as BunifuImageButton).Tag);
            billDAO dao = new billDAO();
            dao.removeQuantityBillinfo(billcurrent.Bill_ID, pid);
            loadBill();
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            Product p = (sender as PictureBox).Tag as Product;
            addToBill_GUI add = new addToBill_GUI(p,staff,tablecurrent);
            this.Opacity = 0.93;
            add.ShowDialog();
            this.Opacity = 1;
            loadBill();
        }

        #region loadGenre
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
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải lại dữ liệu...");
            int t = Convert.ToInt32((sender as BunifuButton).Tag);
            loadMenu(t);
            txtSearch.Clear();
            SplashScreenManager.CloseForm();
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
            if (Bill.Controls.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 món!", "Lỗi thanh toán!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                billDAO dao  = new billDAO();
                if (billcurrent.Bill_isTakeAway == true)
                {
                    Checkout_GUI check = new Checkout_GUI(billcurrent.Bill_ID, true,staff,false);
                    check.ShowDialog();
                    if (dao.checkStatusBill(billcurrent.Bill_ID))
                    {
                        this.Close();
                    }
                }
                else
                {
                    Checkout_GUI check = new Checkout_GUI(billcurrent.Bill_ID, false,staff,false);
                    check.ShowDialog();
                    if (dao.checkStatusBill(billcurrent.Bill_ID))
                    {
                        this.Close();
                    }
                }
            }
        }
        Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();

    }
}
