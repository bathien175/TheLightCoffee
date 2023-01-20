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
    public partial class single_Import_GUI : Form
    {
        private String staffcur;
        private Ingredient ingredientcur;
        private int sl;
        bool changePrice = false;
        private long oldPrice;
        private long newPrice;
        private bool dotPress = false;
        public single_Import_GUI(String staffcode,int ingreid)
        {
            InitializeComponent();
            setData(staffcode, ingreid);
            oldPrice = convertMoney(lblPrice.Text);
            newPrice = oldPrice;
        }
        long convertMoney(String s)
        {
            String s2 = "";
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                {
                    s2 += item;
                }
            }
            return long.Parse(s2);
        }
        void setData(String s, int i)
        {
            IngredientDAO dao = new IngredientDAO();
            this.staffcur = s;
            this.ingredientcur = dao.searchIngredientbyID(i);
            lblPrice.Text = String.Format("{0:0,0 vnđ}", ingredientcur.Ingredient_PriceImport);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void setSL()
        {
            sl = Convert.ToInt32(lblSL.Text);
            lblTotalMoney.Text = "Thành tiền : " + String.Format("{0:0,0 vnđ}", (sl * convertMoney(lblPrice.Text)));
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (sl == 0)
            {
                MessageBox.Show("Số lượng không được bằng 0 !", "Lỗi số lượng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //import
                IngredientDAO dao = new IngredientDAO();
                if (dao.ImportSingle(staffcur, ingredientcur.Ingredient_ID, sl, convertMoney(lblPrice.Text)))
                {
                    MessageBox.Show("Quá trình nhập hàng hoàn tất!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tiền trong ngân sách không đủ để chi trả!", "Lỗi thiếu ngân sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!changePrice)
            {
                if (lblSL.Text == "0")
                {
                    lblSL.Text = "1";
                }
                else
                {
                    lblSL.Text += "1";
                }
                setSL();
            }
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "1";
                }
                else
                {
                    s = "1";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "2";
                }
                else
                {
                    s = "2";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "3";
                }
                else
                {
                    s = "3";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "4";
                }
                else
                {
                    s = "4";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "5";
                }
                else
                {
                    s = "5";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "6";
                }
                else
                {
                    s = "6";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "7";
                }
                else
                {
                    s = "7";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "8";
                }
                else
                {
                    s = "8";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!changePrice)
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
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "9";
                }
                else
                {
                    s = "9";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!changePrice)
            {
                if (lblSL.Text != "0")
                {
                    lblSL.Text += "0";
                }
                setSL();
            }
            else
            {
                String s = newPrice.ToString();
                if (s != "0")
                {
                    s += "0";
                }
                newPrice = Convert.ToInt64(s);
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }       
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            //if (!changePrice)
            //{
            //    if (!dotPress)
            //    {
            //        lblSL.Text += ".";
            //        setSL();
            //    }
                
            //}
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!changePrice)
            {
                if (lblSL.Text.Length > 1)
                {
                    String s = "";
                    for (int i = 0; i < lblSL.Text.Length; i++)
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
            else
            {
                if (newPrice.ToString().Length > 1)
                {
                    String s = "";
                    for (int i = 0; i < newPrice.ToString().Length; i++)
                    {
                        if (i != newPrice.ToString().Length - 1)
                        {
                            s += newPrice.ToString()[i];
                        }
                    }
                    newPrice = Convert.ToInt64(s);
                }
                else
                {
                    newPrice = 0;
                }
                lblPrice.Text = String.Format("{0:0,0 vnđ}", newPrice);
            }
            
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if (btnChangePrice.ButtonText=="Sửa giá")
            {
                btnChangePrice.ButtonText = "Cập nhật"; //Vào chế độ sửa giá
                btnOldPrice.Visible= true;
                changePrice = true;
                lblPrice.BackColor = Color.GreenYellow;
            }
            else
            {
                if(newPrice%1000!=0|| newPrice < 1000)
                {
                    MessageBox.Show("Giá tiền không hợp lệ!","Lỗi tiền không hợp lệ!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    btnChangePrice.ButtonText = "Sửa giá"; //cập nhật giá nhập thực tế
                    btnOldPrice.Visible = false;
                    changePrice = false;
                    lblPrice.BackColor = Color.White;
                    setSL();
                }
            }
        }

        private void btnOldPrice_Click(object sender, EventArgs e)
        {
            lblPrice.Text = String.Format("{0:0,0 vnđ}", oldPrice);
            changePrice = false;
            btnChangePrice.ButtonText = "Sửa giá";
            lblPrice.BackColor = Color.White;
            btnOldPrice.Visible = false;
        }
    }
}
