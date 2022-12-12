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
    public partial class Checkout_GUI : Form
    {
        bool err = true;
        private int txtChange = 0;
        private String DiscountMoney = "0";
        private String CusGiveMoney = "0";
        private long totalMoneyFirst = 0, totalMoneyLast = 0;
        private long cusRecive =0;
        private long extraFeeTotal = 0;
        private int billid;
        private bool takeaway = false;
        private Staff staffcurr = new Staff();
        public Checkout_GUI(int BillID, bool istakeaway,Staff s)
        {
            InitializeComponent();
            this.billid= BillID;
            takeaway=istakeaway;
            this.staffcurr= s;
            loadCbbExtraFee();
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                totalMoneyFirst = (long)db.TotalMoney(billid).FirstOrDefault();
            }
            lblData.Text = "Thanh toán hóa đơn #" + billid.ToString();
            lblTotalMoney1.Text = String.Format("{0:0,0}", Convert.ToInt64(totalMoneyFirst));
            totalMoneyLast = totalMoneyFirst;
            lblTotalmoney2.Text = String.Format("{0:0,0}", Convert.ToInt64(totalMoneyLast));
        }
        void setTotalMoney()
        {
            long discount = Convert.ToInt64(DiscountMoney);
            totalMoneyLast = (totalMoneyFirst + extraFeeTotal) - discount;
            lblTotalmoney2.Text = String.Format("{0:0,0}", Convert.ToInt64(totalMoneyLast));
            cusRecive = Convert.ToInt64(CusGiveMoney) - totalMoneyLast;
            txtCusRecive.Text = String.Format("{0:0,0}", cusRecive);
        }
        void loadCbbExtraFee()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                cbbSurchange.DataSource = db.Surcharges.Where(x => x.Surcharge_DateEnd == null).Select(x => x.Surcharge_Name).ToList();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            String type = (sender as DevExpress.XtraEditors.CheckButton).Text;
            switch (type)
            {
                case "Tiền mặt":
                    btnMoney.Checked = true;
                    btnBank.Checked = false;
                    btnMomo.Checked = false;
                    btnZalopay.Checked = false;
                    break;
                case "Ngân hàng":
                    btnBank.Checked = true;
                    btnMoney.Checked = false;
                    btnMomo.Checked = false;
                    btnZalopay.Checked = false;
                    break;
                case "MoMo":
                    btnMomo.Checked = true;
                    btnMoney.Checked = false;
                    btnZalopay.Checked = false;
                    btnBank.Checked = false;
                    break;
                case "ZaloPay":
                    btnZalopay.Checked = true;
                    btnMoney.Checked = false;
                    btnMomo.Checked = false;
                    btnBank.Checked = false;
                    break;
            }
        }
        void setMoney(TextBox t)
        {
            if (t == txtDiscountMoney)
            {
                t.Text = String.Format("{0:0,0}", Convert.ToInt64(DiscountMoney));
            }
            else
            {
                t.Text = String.Format("{0:0,0}", Convert.ToInt64(CusGiveMoney));
            }   
        }
        void textchange(char s, TextBox t)
        {
            if(t == txtDiscountMoney)
            {
                if (DiscountMoney == "0")
                {
                    DiscountMoney = s.ToString();
                }
                else
                {
                    DiscountMoney += s;
                }
            }
            else
            {
                if (CusGiveMoney == "0")
                {
                    CusGiveMoney = s.ToString();
                }
                else
                {
                    CusGiveMoney += s;
                }
            }
            setMoney(t);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('1',txtDiscountMoney);
            }
            else
            {
                if(txtChange == 2)
                {
                    textchange('1', txtCusGive);
                }
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('2', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('2', txtCusGive);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('3', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('3', txtCusGive);
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('4', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('4', txtCusGive);
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('5', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('5', txtCusGive);
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('6', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('6', txtCusGive);
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('7', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('7', txtCusGive);
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('8', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('8', txtCusGive);
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('9', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('9', txtCusGive);
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                textchange('0', txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    textchange('0', txtCusGive);
                }
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                DiscountMoney = "0";
                setMoney(txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    CusGiveMoney = "0";
                    setMoney(txtCusGive);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtChange == 1)
            {
                if (DiscountMoney.Length > 1)
                {
                    String s = "";
                    for (int i = 0; i < DiscountMoney.Length; i++)
                    {
                        if (i != DiscountMoney.Length - 1)
                        {
                            s += DiscountMoney[i];
                        }
                    }
                    DiscountMoney = s;
                }
                else
                {
                    DiscountMoney = "0";
                }
                setMoney(txtDiscountMoney);
            }
            else
            {
                if (txtChange == 2)
                {
                    if (CusGiveMoney.Length > 1)
                    {
                        String s = "";
                        for (int i = 0; i < CusGiveMoney.Length; i++)
                        {
                            if (i != CusGiveMoney.Length - 1)
                            {
                                s += CusGiveMoney[i];
                            }
                        }
                        CusGiveMoney = s;
                    }
                    else
                    {
                        CusGiveMoney = "0";
                    }
                    setMoney(txtCusGive);
                }
            }
        }

        private void txtDiscountMoney_Enter(object sender, EventArgs e)
        {
            txtChange = 1;
        }

        bool checkDiscount()
        {
            if (Convert.ToInt64(DiscountMoney) > totalMoneyLast)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool checkCusGive()
        {
            if (Convert.ToInt64(CusGiveMoney) < totalMoneyLast)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void txtDiscountMoney_Leave(object sender, EventArgs e)
        {
            if (!checkDiscount())
            {
                MessageBox.Show("Tiền giảm giá không được lớn hơn tổng tiền hóa đơn!", "Lỗi giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscountMoney.Focus();
            }
            else
            {
                txtChange = 0;
            }
        }

        private void txtCusGive_Enter(object sender, EventArgs e)
        {
            txtChange = 2;
        }

        private void txtCusGive_Leave(object sender, EventArgs e)
        {
            if (!checkCusGive())
            {
                MessageBox.Show("Tiền trả không được nhỏ hơn tổng tiền hóa đơn!", "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCusGive.Focus();
            }
            else
            {
                txtChange = 0;
                cusRecive = Convert.ToInt64(CusGiveMoney) - totalMoneyLast;
                txtCusRecive.Text = String.Format("{0:0,0}", cusRecive);
            }
        }

        private void txtDiscountMoney_TextChanged(object sender, EventArgs e)
        {
            setTotalMoney();
        }

        private void lblTotalmoney2_TextChanged(object sender, EventArgs e)
        {
            cusRecive = Convert.ToInt64(CusGiveMoney) - totalMoneyLast;
            txtCusRecive.Text = String.Format("{0:0,0}", cusRecive);
        }
        void addSurchangeToBill(int id)
        {
                billDAO dao = new billDAO();
                dao.addSurchange(billid, id);
        }
        void removeSurchange(int tbid)
        {
            int x =0;
            foreach (DataGridViewRow item in tbSurchange.Rows)
            {
                if(item.Index== tbid)
                { x = Convert.ToInt32(item.Cells[0].Value); tbSurchange.Rows.RemoveAt(item.Index); }
            }
            billDAO dao = new billDAO();
            dao.removeSurchange(billid, x);
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!checkDiscount() || !checkCusGive())
            {
                MessageBox.Show("Vui lòng kiểm tra tiền giảm giá và tiền khách hàng trả!", "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //tinh tien
                billDAO dao = new billDAO();
                dao.checkOut(billid, Convert.ToInt64(DiscountMoney), extraFeeTotal, totalMoneyLast);
                if (takeaway == true)
                {
                    List<billIsTakeAway> list = new List<billIsTakeAway>();
                    using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
                    {

                        var x = db.exportBillTakeAway(billid).ToList();
                        foreach (exportBillTakeAway_Result item in x)
                        {
                            billIsTakeAway b = new billIsTakeAway();
                            b.Bill_Code = item.Bill_Code;
                            b.Bill_Staff = item.Bill_Staff;
                            b.Bill_Discount = item.Bill_Discount;
                            b.Bill_ExtraFee = Convert.ToInt64(item.Bill_ExtraFee);
                            b.Bill_Product = item.Bill_Product;
                            b.Bill_Quantity = item.Bill_Quantity;
                            b.Bill_UnitPrice = item.Bill_UnitPrice;
                            b.Bill_TotalMoney = item.Bill_TotalMoney;
                            list.Add(b);
                        }
                        printBill print = new printBill();
                        this.Close();
                        print.PrintBill(list, Convert.ToInt64(CusGiveMoney), Convert.ToInt64(cusRecive));
                        print.ShowDialog();
                    }
                }
                else
                {
                    List<billnoTakeAway> list = new List<billnoTakeAway>();
                    using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
                    {

                        var x = db.exportBillNoTakeAway(billid).ToList();
                        foreach (exportBillNoTakeAway_Result item in x)
                        {
                            billnoTakeAway b = new billnoTakeAway();
                            b.Bill_Code = item.Bill_Code;
                            b.Bill_Staff = item.Bill_Staff;
                            b.Bill_Discount = item.Bill_Discount;
                            b.Bill_ExtraFee = Convert.ToInt64(item.Bill_ExtraFee);
                            b.Bill_Product = item.Bill_Product;
                            b.Bill_Quantity = item.Bill_Quantity;
                            b.Bill_UnitPrice = item.Bill_UnitPrice;
                            b.Bill_TotalMoney = item.Bill_TotalMoney;
                            b.Bill_Table = item.Bill_Table;
                            b.Bill_TimeFrom = item.Bill_TimeFrom;
                            b.Bill_TimeTo = Convert.ToDateTime(item.Bill_TimeTo);
                            list.Add(b);
                        }
                        printBill print = new printBill();
                        this.Close();
                        print.PrintBillTable(list, Convert.ToInt64(CusGiveMoney), Convert.ToInt64(cusRecive));
                        print.ShowDialog();
                    }
                }
            }   
        }

        private void tbSurchange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbSurchange.Columns[e.ColumnIndex].Name == "deleteSur")
            {
                removeSurchange(e.RowIndex);
            }
        }

        private void btnAddSurchange_Click(object sender, EventArgs e)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.Surcharges.Where(x => x.Surcharge_Name == cbbSurchange.Text && x.Surcharge_DateEnd == null).FirstOrDefault();
                if (tbSurchange.RowCount == 0)
                {
                    tbSurchange.Rows.Add(s.Surcharge_ID, s.Surcharge_Name, String.Format("{0:0,0 vnđ}", s.Surcharge_Price), (s.Surcharge_DateStart).ToShortDateString());
                    extraFeeTotal += s.Surcharge_Price;
                    addSurchangeToBill(s.Surcharge_ID);
                }
                else
                {
                    foreach (DataGridViewRow item in tbSurchange.Rows)
                    {
                        if (item.Cells[0].Value.ToString() == s.Surcharge_ID+"")
                        {
                            MessageBox.Show("Đã áp dụng phí này rồi!");
                        }
                        else
                        {
                            tbSurchange.Rows.Add(s.Surcharge_ID, s.Surcharge_Name, String.Format("{0:0,0 vnđ}", s.Surcharge_Price), (s.Surcharge_DateStart).ToShortDateString());
                            extraFeeTotal += s.Surcharge_Price;
                            addSurchangeToBill(s.Surcharge_ID);
                        }
                    }
                }
            }
            setTotalMoney();
        }
    }
}
