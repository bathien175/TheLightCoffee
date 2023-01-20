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
    public partial class item_Import : UserControl
    {
        private int id;
        private double sl;
        private long price,total;
        private String name, unit;
        private byte[] image;
        public item_Import()
        {
            InitializeComponent();

        }
        public int getSetID
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
        public double getSetSL
        {
            get
            {
                return sl;
            }
            set
            {
                sl = value;
                lblSL.Text = sl.ToString();
                double check = Math.Ceiling(Math.Round((Convert.ToDouble(price * sl) / 1000), 1));
                getSetTotal = Convert.ToInt64(check * 1000);
            }
        }
        public String getSetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                lblNameIngredient.Text = name;
            }
        }
        public String getSetUnit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                lblUnit.Text = unit;
            }
        }
        public byte[] getSetImage
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                imgIngredient.Image = Base64ToImage(image);
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public long getSetPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                lblPrice.Text = String.Format("{0:0,0}", price) + " VNĐ";
                double check = Math.Ceiling(Math.Round((Convert.ToDouble(price*sl) / 1000), 1));
                getSetTotal = Convert.ToInt64(check * 1000);
            }
        }

        private void lblPrice_Leave(object sender, EventArgs e)
        {
            getSetPrice = convertMoney(lblPrice.Text);

        }
        long convertMoney(String s)
        {
            String money = "";
            if (s.Length == 0)
            {
                return 0;
            }
            else
            {
                foreach (var item in s)
                {
                    if (char.IsDigit(item))
                    {
                        money += item;
                    }
                }
                if (money.Length == 0)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt64(money);
                }
            }
        }
        public long getSetTotal
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                lblTotal.Text = String.Format("{0:0,0}", total) + " VNĐ";
            }
        }
        public BunifuImageButton getbtnSub()
        {
            return btnSub;
        }
        public BunifuImageButton getbtnDel()
        {
            return btnDel;
        }
        public void errorMoney(bool t)
        {
            if (t)
            {
                lblPrice.BackColor = Color.Red;
            }
            else
            {
                lblPrice.BackColor = Color.White;
            }
           
        }
    }
}
