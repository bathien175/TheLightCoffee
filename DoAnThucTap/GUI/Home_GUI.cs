using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class Home_GUI : Form
    {
        Staff s = new Staff();
        public Home_GUI(Staff staff)
        {
            InitializeComponent();
            s = staff;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_GUI_Load(object sender, EventArgs e)
        {
            lblNameStaff.Text = s.Staff_Name;
            if (s.Staff_isAdmin == true)
            {
                imgAvatar.Image = DoAnThucTap.Properties.Resources.manager;
            }
            else
            {
                imgAvatar.Image = DoAnThucTap.Properties.Resources.waiter;
            }
            lblTime.Text = DateTime.Now.ToString();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            ChooseTable_GUI choose = new ChooseTable_GUI(s);
            this.Hide();
            choose.ShowDialog();
            this.Show();
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            Sell_GUI sell = new Sell_GUI("TakeAway",s);
            this.Hide();
            sell.ShowDialog();
            this.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //form cá nhân
            Persional_GUI per = new Persional_GUI(s.Staff_Code);
            this.Hide();
            per.ShowDialog();
            this.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Product_GUI product_GUI = new Product_GUI();
            this.Hide();
            product_GUI.ShowDialog();
            this.Show();
        }

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            Ingredient_GUI ingredient = new Ingredient_GUI(s.Staff_Code);
            this.Hide();
            ingredient.ShowDialog();
            this.Show();
        }

        private void btnReportDay_Click(object sender, EventArgs e)
        {
            printReportDate date = new printReportDate();
            date.ShowDialog();
        }
    }
}
