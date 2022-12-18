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
        public single_Import_GUI(String staffcode,int ingreid)
        {
            InitializeComponent();
            setData(staffcode, ingreid);
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
            lblTotalMoney.Text = "Thành tiền : " + String.Format("{0:0,0 vnđ}", (sl * ingredientcur.Ingredient_PriceImport));
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            //import
            IngredientDAO dao = new IngredientDAO();
            dao.ImportSingle(staffcur, ingredientcur.Ingredient_ID, sl);
            MessageBox.Show("Quá trình nhập hàng hoàn tất!","Chúc mừng",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
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
    }
}
