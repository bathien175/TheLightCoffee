using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;

namespace DoAnThucTap.userControl
{
    public partial class itemTable : UserControl
    {
        private String table;
        private int status;
        private DateTime time;
        private int countBill;
        public itemTable()
        {
            InitializeComponent();
        }

        public String TableCode
        {
            get { return table; }
            set 
            { 
                table = value;
                lblTableCode.Text = "Bàn " + value;
            }
        }
        public int QuantityBill
        {
            get { return countBill; }
            set
            {
                countBill = value;
                lblTotalBill.Text = value.ToString();
            }
        }
        public int TableStatus
        {
            get { return status; }
            set
            {
                status = value;
                switch(status) 
                {
                    case 0: 
                        lblStatus.Text = "Bàn trống";
                        this.BackColor = Color.DarkSlateGray;
                        bunifuPanel2.BackgroundColor = Color.DarkCyan;
                        lblTime.Visible= false;
                        break;
                    case 1: 
                        lblStatus.Text = "Có khách";
                        this.BackColor = Color.DarkGoldenrod;
                        bunifuPanel2.BackgroundColor = Color.Goldenrod;
                        lblTime.Visible = true;
                        break;
                    case 2: 
                        lblStatus.Text = "Đặt trước";
                        this.BackColor = Color.DarkRed;
                        bunifuPanel2.BackgroundColor = Color.Red;
                        lblTime.Visible = false;
                        break;
                }
            }
        }
        public ContextMenuStrip GetMenuStrip()
        {
            return menuTrip;
        }

        public Bunifu.UI.WinForms.BunifuImageButton GetImageButton()
        {
            return btnOptionBill;
        }
    }
}
