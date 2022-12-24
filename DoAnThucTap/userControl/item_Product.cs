using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.userControl
{
    public partial class item_Product : UserControl
    {
        private int id;
        private String namePro, cateName, unitPro;
        private long pricePro;
        private byte[] imagePro;
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
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public byte[] imageProduct
        {
            get
            {
                return imagePro;
            }
            set
            {
                imagePro = value;
                pictureProduct.Image = Base64ToImage(imagePro);
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
