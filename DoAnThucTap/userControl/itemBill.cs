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
    public partial class itemBill : UserControl
    {
        private String name;
        private int sl;
        public itemBill()
        {
            InitializeComponent();
        }
        public String nameMenu {
            get { return name; }
            set { name = value; lblName.Text = value; }
        }
        public int slMenu {
            get { return sl; }
            set { sl = value; lblSL.Text = "x" + value; }
        }
        public int productid { get; set; }

        public Bunifu.UI.WinForms.BunifuImageButton btnDel()
        {
            return btnDelete;
        }
    }
}
