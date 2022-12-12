using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.userControl
{
    public partial class item_Product : UserControl
    {
        private int id;
        private String namePro, imagePro, cateName, unitPro;
        private long pricePro;
        public item_Product()
        {
            InitializeComponent();
        }
        public int idProduct
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                lblID.Text = id.ToString();
            }
        }

        public String nameProduct
        {
            get
            {
                return namePro;
            }
            set 
            { 
                namePro = value;
                lblNameProduct.Text = namePro.ToString();
            }
        }

        public String imageProduct
        {
            get
            {
                return imagePro;
            }
            set
            {
                imagePro = value;
                pictureProduct.Image = Image.FromFile(@"../../ImageProduct/"+imagePro);
            }
        }
        public long priceProduct
        {
            get
            {
                return pricePro;
            }
            set
            {
                pricePro = value;
                lblPrice.Text = String.Format("{0:0,0}", pricePro)+" VNĐ";
            }
        }

        public String cateNameProduct
        {
            get
            {
                return this.cateName;
            }
            set
            {
                this.cateName = value;
                lblCate.Text = cateName.ToString();
            }
        }

        public String unitProduct
        {
            get
            {
                return this.unitPro;
            }
            set
            {
                this.unitPro = value;
                lblUnit.Text = unitPro.ToString();
            }
        }

        public BunifuImageButton detailButton
        {
            get { return btnDetail; }
        }
    }
}
