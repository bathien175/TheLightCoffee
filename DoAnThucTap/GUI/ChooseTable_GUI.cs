using DevExpress.XtraSplashScreen;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using DoAnThucTap.userControl;
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
    public partial class ChooseTable_GUI : Form
    {
        private String tableCode = "";
        private Staff staff= null;private int stat = 0;
        public ChooseTable_GUI(Staff s)
        {
            InitializeComponent();
            loadTable(0);
            this.staff= s;
        }

        void loadTable(int state)
        {
            showTable.Controls.Clear();
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            tableDAO dao = new tableDAO();
            switch (state) {
                case 0:
                    List<tableBill> l = dao.getTablehaveBill();
                    if (l.Count > 0)
                    {
                        foreach (tableBill item in l)
                        {
                            itemTable tb = new itemTable();
                            tb.TableCode = item.dbtable.Table_Code;
                            tb.TableStatus = item.dbtable.Table_Status;
                            tb.QuantityBill = item.BillQuantity;
                            tb.GetTime = item.BillTime;
                            Bunifu.UI.WinForms.BunifuImageButton btn = tb.GetImageButton();
                            btn.Tag = tb.TableCode;
                            btn.MouseClick += Btn_MouseClick;
                            showTable.Controls.Add(tb);
                        }
                    }
                    break;
                case 1:
                    List<tableBill> l1 = dao.getTablebyLocation("Tầng trệt");
                    if (l1.Count > 0)
                    {
                        foreach (tableBill item in l1)
                        {
                            itemTable tb = new itemTable();
                            tb.TableCode = item.dbtable.Table_Code;
                            tb.TableStatus = item.dbtable.Table_Status;
                            tb.QuantityBill = item.BillQuantity;
                            tb.GetTime = item.BillTime;
                            Bunifu.UI.WinForms.BunifuImageButton btn = tb.GetImageButton();
                            btn.Tag = tb.TableCode;
                            btn.MouseClick += Btn_MouseClick;
                            showTable.Controls.Add(tb);
                        }
                    }
                    break;
                case 2:
                    List<tableBill> l2 = dao.getTablebyLocation("Tầng 1");
                    if (l2.Count > 0)
                    {
                        foreach (tableBill item in l2)
                        {
                            itemTable tb = new itemTable();
                            tb.TableCode = item.dbtable.Table_Code;
                            tb.TableStatus = item.dbtable.Table_Status;
                            tb.QuantityBill = item.BillQuantity;
                            tb.GetTime = item.BillTime;
                            Bunifu.UI.WinForms.BunifuImageButton btn = tb.GetImageButton();
                            btn.Tag = tb.TableCode;
                            btn.MouseClick += Btn_MouseClick;
                            showTable.Controls.Add(tb);
                        }
                    }
                    break;
                case 3:
                    List<tableBill> l3 = dao.getTablebyLocation("Tầng 2");
                    if (l3.Count > 0)
                    {
                        foreach (tableBill item in l3)
                        {
                            itemTable tb = new itemTable();
                            tb.TableCode = item.dbtable.Table_Code;
                            tb.TableStatus = item.dbtable.Table_Status;
                            tb.QuantityBill = item.BillQuantity;
                            tb.GetTime = item.BillTime;
                            Bunifu.UI.WinForms.BunifuImageButton btn = tb.GetImageButton();
                            btn.Tag = tb.TableCode;
                            btn.MouseClick += Btn_MouseClick; ;
                            showTable.Controls.Add(tb);
                        }
                    }
                    break;
            }
            SplashScreenManager.CloseForm();
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tableCode = (sender as Bunifu.UI.WinForms.BunifuImageButton).Tag.ToString();
                tableDAO dao = new tableDAO();
                int i = dao.checkStatusTable(tableCode);
                switch (i)
                {
                    case 0:
                        createBill.Enabled= true; 
                        bookTable.Enabled= true;
                        cancleBook.Enabled= false;
                        detailBill.Enabled= false;
                        menuTrip.Show((sender as Bunifu.UI.WinForms.BunifuImageButton).PointToScreen(e.Location));
                        break;
                    case 1:
                        createBill.Enabled = false;
                        bookTable.Enabled = false;
                        cancleBook.Enabled = false;
                        detailBill.Enabled = true;
                        menuTrip.Show((sender as Bunifu.UI.WinForms.BunifuImageButton).PointToScreen(e.Location));
                        break;
                    case 2:
                        createBill.Enabled = false;
                        bookTable.Enabled = false;
                        cancleBook.Enabled = true;
                        detailBill.Enabled = false;
                        menuTrip.Show((sender as Bunifu.UI.WinForms.BunifuImageButton).PointToScreen(e.Location));
                        break;
                    case -1:
                        MessageBox.Show("Không tìm được bàn!");break;
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocation0_Click(object sender, EventArgs e)
        {
            loadTable(1);
            stat = 1;
        }

        private void btnLocation1_Click(object sender, EventArgs e)
        {
            loadTable(2);
            stat = 2;
        }

        private void btnLocation2_Click(object sender, EventArgs e)
        {
            loadTable(3);
            stat = 3;
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            loadTable(0);
            stat= 0;
        }

        private void createBill_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            Sell_GUI sell = new Sell_GUI(tableCode,staff);
            this.Hide();
            SplashScreenManager.CloseForm();
            sell.ShowDialog();
            this.Show();
            loadTable(stat);

        }

        private void bookTable_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Quyết định đặt bàn số "+tableCode,"Chờ đã!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                tableDAO dao = new tableDAO();
                dao.bookingTable(tableCode);
                loadTable(stat);
            }  
        }

        private void cancleBook_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn hủy đặt bàn số " + tableCode, "Chờ đã!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                tableDAO dao = new tableDAO();
                dao.cancelbookingTable(tableCode);
                loadTable(stat);
            }
        }

        private void detailBill_Click(object sender, EventArgs e)
        {
            
        }

        private void chỉnhSửaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            Sell_GUI sell = new Sell_GUI(tableCode, staff);
            this.Hide();
            SplashScreenManager.CloseForm();
            sell.ShowDialog();
            this.Show();
            loadTable(0);
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            swithTable_GUI switchtb = new swithTable_GUI(tableCode);
            SplashScreenManager.CloseForm();
            switchtb.ShowDialog();
            loadTable(stat);
        }

        private void thanhToánTáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billDAO dao = new billDAO();
            split_Bill_GUI split = new split_Bill_GUI(dao.getBillbyTableID(tableCode).Bill_ID,staff.Staff_Code);
            this.Close();
            split.ShowDialog();
        }
    }
}
