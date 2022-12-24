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
    public partial class item_Ingredient : UserControl
    {
        private int id;
        private double reserved;
        private string name, unit;
        private byte[] image;
        private long price;
        public int code { get; set; }
        public item_Ingredient()
        {
            InitializeComponent();
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public int idIngredient
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

        public double reservedIngredient
        {
            get { return reserved; } set
            {
                reserved = value;
                lblReserved.Text = reserved.ToString();
            }
        }

        public String nameIngredient
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                lblName.Text = name.ToString();
            }
        }

        public long priceIngredient
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                lblPrice.Text = String.Format("{0:0,0}", price) + " VNĐ";
            }
        }
        public string unitIngredient
        {
            get { return unit; }
            set
            {
                unit = value;
                lblUnit.Text = unit.ToString();
            }
        }
        public byte[] imageIngredient
        {
            get 
            { 
                return image;
            }
            set
            {
                image = value;
                pictureBox1.Image = Base64ToImage(image);
            }
        }

        public BunifuImageButton getBtn()
        {
            return bunifuImageButton1;
        }

    }
}
