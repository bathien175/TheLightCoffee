using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;

namespace DoAnThucTap.userControl
{
    public partial class itemMenu : UserControl
    {
        private String name;
        private String price;
        private Image img;
        private int sl;
        public itemMenu()
        {
            InitializeComponent();
        }
        public String nameMenu
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                lblNameMenu.Text= value;
            }
        }
        public String priceMenu
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
                lblPrice.Text = value;
            }
        }
        public Image imageProduct
        {
            get
            {
                return this.img;
            }
            set
            {
                this.img = value;
                imageMenu.Image= value;
            }
        }
        public int QuantityProduct
        {
            get
            {
                return this.sl;
            }
            set
            {
                this.sl = value;
            }
        }
        public PictureBox getpicture()
        {
            return imageMenu;
        }
        public int productid { get; set; }
    }
}
