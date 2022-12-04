using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
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
    public partial class addToBill_GUI : Form
    {
        private Product productCur = new Product();
        private DBTable tableCur = new DBTable();
        private Staff staffCur = new Staff();
        private int sl;
        public addToBill_GUI(Product p,Staff s,DBTable tb)
        {
            InitializeComponent();
            staffCur = s;
            productCur = p;
            tableCur = tb;
            menuDAO dao = new menuDAO();
            lblNameMenu.Text = productCur.Product_Name;
            lblPrice.Text = String.Format("{0:0,0 vnđ}", productCur.Product_Price);
            setSL();
        }

        void setSL()
        {
            sl = Convert.ToInt32(lblSL.Text);
            lblTotalMoney.Text = "Thành tiền : " + String.Format("{0:0,0 vnđ}", (sl * productCur.Product_Price));
        }
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(lblSL.Text =="0")
            {
                lblSL.Text = "1";
            }
            else
            {
                lblSL.Text += "1";
            }
            setSL();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "2";
            }
            else
            {
                lblSL.Text += "2";
            }
            setSL();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "3";
            }
            else
            {
                lblSL.Text += "3";
            }
            setSL();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "4";
            }
            else
            {
                lblSL.Text += "4";
            }
            setSL();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "5";
            }
            else
            {
                lblSL.Text += "5";
            }
            setSL();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "6";
            }
            else
            {
                lblSL.Text += "6";
            }
            setSL();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "7";
            }
            else
            {
                lblSL.Text += "7";
            }
            setSL();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "8";
            }
            else
            {
                lblSL.Text += "8";
            }
            setSL();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblSL.Text == "0")
            {
                lblSL.Text = "9";
            }
            else
            {
                lblSL.Text += "9";
            }
            setSL();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblSL.Text != "0")
            {
                lblSL.Text += "0";
            }
            setSL();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblSL.Text.Length > 1)
            {
                String s = "";
                for(int i = 0; i < lblSL.Text.Length; i++)
                {
                    if (i != lblSL.Text.Length - 1)
                    {
                        s += lblSL.Text[i];
                    }
                }
                lblSL.Text = s;
            }
            else
            {
                lblSL.Text = "0";
            }
            setSL();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(lblSL.Text == "0") 
            {
                MessageBox.Show("Hãy chọn một con số hợp lệ!","Lỗi chọn số lượng!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (tableCur == null)
                {
                    // code thêm món
                    try
                    {
                        billDAO dao = new billDAO();
                        dao.addBillInfoTakeAway(productCur.Product_ID, sl, staffCur.Staff_Code);
                        MessageBox.Show("Thêm món thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("xin lỗi! Hệ thống đang xảy ra quá tải!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //code thêm món
                    try
                    {
                        billDAO dao = new billDAO();
                        dao.addBillInfo(tableCur.Table_Code, productCur.Product_ID, sl, staffCur.Staff_Code);
                        MessageBox.Show("Thêm món thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("xin lỗi! Hệ thống đang xảy ra quá tải!", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
