﻿using DevExpress.XtraSplashScreen;
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
        private String DiscountString = "0";
        private String CusGiveMoney = "0";
        private long totalMoneyFirst = 0, totalMoneyLast = 0;
        private long cusRecive =0;
        private long extraFeeTotal = 0;
        private int billid;
        private bool takeaway = false;
        private Staff staffcurr = new Staff();
        private bool split;
        private List<Discount> apllydiscount = new List<Discount>();
        public Checkout_GUI(int BillID, bool istakeaway,Staff s,bool isSPlit)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            InitializeComponent();
            split = isSPlit;
            this.billid= BillID;
            takeaway=istakeaway;
            this.staffcurr= s;
            loadCbbDiscount();
            loadCbbExtraFee();
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                totalMoneyFirst = (long)db.TotalMoney(billid).FirstOrDefault();
            }
            lblData.Text = "Thanh toán hóa đơn #" + billid.ToString();
            lblTotalMoney1.Text = String.Format("{0:0,0}", Convert.ToInt64(totalMoneyFirst));
            totalMoneyLast = totalMoneyFirst;
            lblTotalmoney2.Text = String.Format("{0:0,0}", Convert.ToInt64(totalMoneyLast));
            loadSurcharge();
            SplashScreenManager.CloseForm();
        }
        void setTotalMoney()
        {
            long discount = Convert.ToInt64(DiscountMoney);
            totalMoneyLast = (totalMoneyFirst + extraFeeTotal) - discount;
            lblTotalmoney2.Text = String.Format("{0:0,0}", Convert.ToInt64(totalMoneyLast));
            cusRecive = Convert.ToInt64(CusGiveMoney) - totalMoneyLast;
            txtCusRecive.Text = String.Format("{0:0,0}", cusRecive);
        }
        void loadCbbDiscount()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                cbbDiscount.DataSource = db.Discounts.Where(x => x.Discount_DateEnd == null).Select(x => x.Discount_name).ToList();
            }
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
            if (split==true)
            {
                billDAO dao = new billDAO();
                dao.removeBillSplit(billid);
                this.Close();
            }
            else
            {
                this.Close();
            }
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
            //txtChange = 1;
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
            //if (!checkDiscount())
            //{
            //    MessageBox.Show("Tiền giảm giá không được lớn hơn tổng tiền hóa đơn!", "Lỗi giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDiscountMoney.Focus();
            //}
            //else
            //{
            //    txtChange = 0;
            //}
        }

        private void txtCusGive_Enter(object sender, EventArgs e)
        {
            txtChange = 2;
        }

        private void txtCusGive_Leave(object sender, EventArgs e)
        {
            cusRecive = Convert.ToInt64(CusGiveMoney) - totalMoneyLast;
            txtCusRecive.Text = String.Format("{0:0,0}", cusRecive);
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
                { 
                    x = Convert.ToInt32(item.Cells[0].Value);
                    String s = tbSurchange.Rows[item.Index].Cells[2].Value.ToString();
                    extraFeeTotal -= convertMoney(s); 
                    tbSurchange.Rows.RemoveAt(item.Index); 
                }
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
                SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
                DialogResult cs = new DialogResult();
                if (split)
                {
                    billDAO dao = new billDAO();
                    dao.checkOutSplit(staffcurr.Staff_Code,billid, Convert.ToInt64(DiscountMoney), extraFeeTotal, totalMoneyLast);
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
                        SplashScreenManager.CloseForm();
                        cs = MessageBox.Show("Bạn có muốn xuất hóa đơn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cs == DialogResult.Yes)
                        {
                            printBill print = new printBill();
                            this.Close();
                            print.PrintBillTable(list, Convert.ToInt64(CusGiveMoney), Convert.ToInt64(cusRecive));
                            print.ShowDialog();
                        }
                        else
                        {
                            this.Close();
                        }
                        
                    }
                }
                else
                {
                    //tinh tien
                    billDAO dao = new billDAO();
                    dao.checkOut(staffcurr.Staff_Code, billid, Convert.ToInt64(DiscountMoney), extraFeeTotal, totalMoneyLast);
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
                            SplashScreenManager.CloseForm();
                            cs = MessageBox.Show("Bạn có muốn xuất hóa đơn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (cs == DialogResult.Yes)
                            {
                                printBill print = new printBill();
                                this.Close();
                                print.PrintBill(list, Convert.ToInt64(CusGiveMoney), Convert.ToInt64(cusRecive));
                                print.ShowDialog();
                            }
                            else
                            {
                                this.Close();
                            }
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
                            SplashScreenManager.CloseForm();
                            cs = MessageBox.Show("Bạn có muốn xuất hóa đơn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (cs == DialogResult.Yes)
                            {
                                printBill print = new printBill();
                                this.Close();
                                print.PrintBillTable(list, Convert.ToInt64(CusGiveMoney), Convert.ToInt64(cusRecive));
                                print.ShowDialog();
                            }
                            else
                            {
                                this.Close();
                            } 
                        }
                    }
                }
                
            }   
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            List<billnoTakeAway> list = new List<billnoTakeAway>();
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var x = db.exportBillNoTakeAway(billid).ToList();
                long total = 0;
                foreach (exportBillNoTakeAway_Result item in x)
                {
                    total += item.Bill_UnitPrice * item.Bill_Quantity;
                }
                foreach (exportBillNoTakeAway_Result item in x)
                {
                    billnoTakeAway b = new billnoTakeAway();
                    b.Bill_Code = item.Bill_Code;
                    b.Bill_Staff = item.Bill_Staff;
                    b.Bill_Discount = Convert.ToInt64(DiscountMoney);
                    if (tbSurchange.Rows.Count > 0)
                    {
                        long surcharge = 0;
                        foreach (DataGridViewRow i in tbSurchange.Rows)
                        {
                            surcharge += convertMoney(i.Cells[2].Value.ToString());
                        }
                        b.Bill_ExtraFee = surcharge;
                    }
                    else
                    {
                        b.Bill_ExtraFee = 0;
                    }
                    b.Bill_Product = item.Bill_Product;
                    b.Bill_Quantity = item.Bill_Quantity;
                    b.Bill_UnitPrice = item.Bill_UnitPrice;
                    b.Bill_TotalMoney = total;
                    b.Bill_Table = item.Bill_Table;
                    b.Bill_TimeFrom = item.Bill_TimeFrom;
                    b.Bill_TimeTo = Convert.ToDateTime(item.Bill_TimeTo);
                    list.Add(b);
                }
            }
            printBill print = new printBill();
            print.PrintBillTable(list, -1, -1);
            SplashScreenManager.CloseForm();
            print.ShowDialog();
        }
        long convertMoney(String s)
        {
            String v = "";
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                {
                    v += item;
                }
            }
            return long.Parse(v);
        }
        private void tbSurchange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbSurchange.Columns[e.ColumnIndex].Name == "deleteSur")
            {
                removeSurchange(e.RowIndex);
                setTotalMoney();
            }
        }
        void loadDiscount()
        {
            tbDiscount.Rows.Clear();
            if (apllydiscount.Count > 0)
            {
                long totaldiscount = 0;
                billDAO dao = new billDAO();
                menuDAO menu = new menuDAO();
                List<Bill_Info> listbill = dao.getListBillInfo(billid);
                foreach (var item in apllydiscount)
                {
                    tbDiscount.Rows.Add(item.Discount_name, item.Discount_Per+"%",item.Discount_ID);
                    if (item.Discount_allProduct == true) //áp dụng tất cả các món
                    {
                        foreach (var i in listbill)
                        {
                            var p = menu.getProductbyID(i.BI_Product);
                            totaldiscount += Convert.ToInt64((p.Product_Price * item.Discount_Per / 100) * i.BI_Quantity);
                        }
                    }
                    else //tìm các món nào được áp dụng voucher này thôi
                    {
                        List<FindDiscount_Result> listdis = menu.searchdiscount(item.Discount_ID);
                        foreach (var i in listbill)
                        {
                            var p = menu.getProductbyID(i.BI_Product);
                            foreach (var k in listdis)
                            {
                                if (k.Discount_Product == i.BI_Product)
                                {
                                    totaldiscount += Convert.ToInt64((p.Product_Price * item.Discount_Per / 100) * i.BI_Quantity);
                                }
                            }
                        }
                    }
                }
                double check = Math.Ceiling(Math.Round((Convert.ToDouble(totaldiscount) / 1000),1));
                DiscountMoney = (check*1000).ToString();
                txtDiscountMoney.Text = String.Format("{0:0,0 vnđ}", Convert.ToInt64(DiscountMoney));
            }
            else
            {
                DiscountMoney = "0";
                txtDiscountMoney.Text = String.Format("{0:0,0 vnđ}", Convert.ToInt64(DiscountMoney)); ;
            }
        }
        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var dis = db.Discounts.Where(x => x.Discount_name == cbbDiscount.Text && x.Discount_DateEnd == null).FirstOrDefault();
                if (dis != null)
                {
                    bool isfind = false;
                    foreach (var item in apllydiscount)
                    {
                        if (dis.Discount_ID == item.Discount_ID)
                        {
                            isfind = true;break;
                        }
                    }
                    if (!isfind)
                    {
                        apllydiscount.Add(dis);
                        loadDiscount();
                    }
                    else
                    {
                        MessageBox.Show("Loại khuyến mãi này đã được áp dụng!","Lỗi trùng lặp!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            setTotalMoney();
        }

        private void tbDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbDiscount.Columns[e.ColumnIndex].Name == "deleteDis")
            {
                int x = 0;
                foreach (DataGridViewRow i in tbDiscount.Rows)
                {
                    if (i.Index == e.RowIndex)
                    { x = Convert.ToInt32(i.Cells[2].Value); tbDiscount.Rows.RemoveAt(i.Index); }
                }
                List<Discount> listnew = new List<Discount>();
                foreach (var item in apllydiscount)
                {
                    if (item.Discount_ID != x)
                    {
                        listnew.Add(item);
                    }
                }
                apllydiscount = listnew;
                loadDiscount();
                setTotalMoney();
            }
        }
        void loadSurcharge()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.getSurcharge(billid).ToList();
                if (s.Count > 0)
                {
                    foreach (var item in s)
                    {
                        var i = db.Surcharges.Where(x => x.Surcharge_ID == item.Surcharge_ID).FirstOrDefault();
                        tbSurchange.Rows.Add(i.Surcharge_ID, i.Surcharge_Name, String.Format("{0:0,0 vnđ}", i.Surcharge_Price), (i.Surcharge_DateStart).ToShortDateString());
                        extraFeeTotal += i.Surcharge_Price;
                    }
                }
            }
            setTotalMoney();
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
