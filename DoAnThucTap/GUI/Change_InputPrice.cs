using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class Change_InputPrice : Form
    {
        private long _price;
        public Change_InputPrice()
        {
            InitializeComponent();
        }
        public BunifuButton getBtnAccept()
        {
            return btnAccept;
        }
        public BunifuButton getBtnClose()
        {
            return btnCancel;
        }
        public long getPrice()
        {
            return _price;
        }
        private void txtChangePrice_Leave(object sender, EventArgs e)
        {
            _price =  convertMoney(txtChangePrice.Text);
            txtChangePrice.Text = String.Format("{0:0,0}", _price) + " VNĐ";
        }

        long convertMoney(String s)
        {
            String money = "";
            if (s.Length == 0)
            {
                return 0;
            }
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
                return long.Parse(money);
            }
        }
    }
}
