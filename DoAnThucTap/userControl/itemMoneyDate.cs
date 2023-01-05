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
    public partial class itemMoneyDate : UserControl
    {
        private Image imgTitle;
        private long money;
        private String Stringmoney;
        private String title;
        public itemMoneyDate()
        {
            InitializeComponent();
        }

        public Image getSetImage
        {
            get
            {
                return imgTitle;
            }
            set
            {
                imgTitle = value;
                pictureBox1.Image = imgTitle;
            }
        }

        public long getMoney
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
                Stringmoney = String.Format("{0:0,0 VND}", money);
                bunifuLabel1.Text = Stringmoney;
            }
        }

        public String Gettitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                bunifuLabel2.Text = title;
            }
        }
    }
}
