using Bunifu.Framework.UI;
using DevExpress.XtraEditors;
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
    public partial class split_Bill_GUI : DevExpress.XtraEditors.XtraForm
    {
        private List<itemBill> listRoot = new List<itemBill>();
        private List<itemBill> listSplit= new List<itemBill>();
        private int bid;
        private Bill billCur;
        private String Staffid;
        public split_Bill_GUI(int billID,String Staffcode)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            InitializeComponent();
            Staffid = Staffcode;
            bid = billID;
            loadDATA();
            Reload_Bill_Root();
            SplashScreenManager.CloseForm();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void split_Bill_GUI_Load(object sender, EventArgs e)
        {

        }
        void loadDATA()
        {
            billDAO dao = new billDAO();
            billCur = dao.getBill(bid);
            List<Bill_Info> list = dao.getListBillInfo(billCur.Bill_ID);
            foreach (var item in list)
            {
                itemBill i = new itemBill();
                i.productid = item.BI_Product;
                i.nameMenu = new menuDAO().getProductbyID(item.BI_Product).Product_Name;
                i.slMenu = item.BI_Quantity;
                listRoot.Add(i);
            }
        }

        private void subItemBill_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32((sender as Bunifu.UI.WinForms.BunifuImageButton).Tag);
            Split(pid);
            Reload_Bill_Split();
            Reload_Bill_Root();
        }

        private void deleteItemBill_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32((sender as Bunifu.UI.WinForms.BunifuImageButton).Tag);
            List<itemBill> listnew = new List<itemBill>();
            foreach (var item in listRoot)
            {
                if (item.productid != pid)
                {
                    listnew.Add(item);

                }
                else
                {
                    addSplit(item);
                }
            }
            listRoot = listnew;
            Reload_Bill_Split();
            Reload_Bill_Root();
        }
        private void subItemSplit_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32((sender as Bunifu.UI.WinForms.BunifuImageButton).Tag);
            List<itemBill> list2 = new List<itemBill>();
            foreach (var item in listSplit) //duyệt list cũ
            {
                if (item.productid == pid)
                {
                    if (item.slMenu > 1)
                    {
                        item.slMenu--;
                        list2.Add(item);
                    }
                    itemBill splitItem = new itemBill();
                    splitItem.productid = pid;
                    splitItem.nameMenu = item.nameMenu;
                    splitItem.slMenu = 1;
                    addRoot(splitItem); //add vô list gốc
                }
                else
                {
                    list2.Add(item);
                }
            }
            listSplit = list2; //tạo ra list mới
            Reload_Bill_Split();
            Reload_Bill_Root();
        }
        void addRoot(itemBill b)
        {
            List<itemBill> list2 = new List<itemBill>();
            if (listRoot.Count != 0)
            {
                int sl = 0;
                foreach (var item in listRoot)
                {
                    if (item.productid == b.productid)
                    {
                        item.slMenu++;
                        list2.Add(item);
                        sl = 1;
                    }
                    else
                    {
                        list2.Add(item);
                    }
                }
                if (sl == 0)
                {
                    list2.Add(b);
                }
                listRoot = list2;
            }
            else
            {
                listRoot.Add(b);
            }

        }
        private void deleteItemSplit_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32((sender as Bunifu.UI.WinForms.BunifuImageButton).Tag);
            List<itemBill> listnew = new List<itemBill>();
            foreach (var item in listSplit)
            {
                if (item.productid != pid)
                {
                    listnew.Add(item);
                    
                }
                else
                {
                    addRoot(item);
                }
            }
            listSplit = listnew;
            Reload_Bill_Split();
            Reload_Bill_Root();
        }
        void Reload_Bill_Root()
        {
            flpRoot.Controls.Clear();
            foreach (var item in listRoot)
            {
                Bunifu.UI.WinForms.BunifuImageButton btndel = item.btnDel();
                Bunifu.UI.WinForms.BunifuImageButton btnsub = item.btnSubtract();
                btndel.Tag = item.productid;
                btnsub.Tag = item.productid;
                btndel.Click -= deleteItemBill_Click;
                btnsub.Click -= subItemBill_Click;
                btndel.Click += deleteItemBill_Click;
                btnsub.Click += subItemBill_Click;
                //item.Width = flpRoot.Width;
                flpRoot.Controls.Add(item);
            }
        }
        void Reload_Bill_Split()
        {
            flpSplit.Controls.Clear();
            foreach (var item in listSplit)
            {
                Bunifu.UI.WinForms.BunifuImageButton btndel = item.btnDel();
                Bunifu.UI.WinForms.BunifuImageButton btnsub = item.btnSubtract();
                btndel.Tag = item.productid;
                btnsub.Tag = item.productid;
                btndel.Click -= deleteItemSplit_Click;
                btnsub.Click -= subItemSplit_Click;
                btndel.Click += deleteItemSplit_Click;
                btnsub.Click += subItemSplit_Click;
                //item.Width-= flpSplit.Width;
                flpSplit.Controls.Add(item);
            }
        }
        //bool checkSL_BillRoot()
        //{
        //    if (listRoot.Count > 1) //Số lượng món trong bill lớn hơn 1 thì được tách thoải mái
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        if (listRoot.Count == 1) //nếu chỉ có một món thì phải kiểm tra số lượng
        //        {
        //            if (listRoot[0].slMenu > 1) // nếu số lượng lớn hơn 1 thì mới tách được
        //            {
        //                //tách tối đa phải giữ cho bill gốc != null
        //                return true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Hóa đơn chỉ có 1 món không thể tách!", "Lỗi số lượng hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
        void addSplit(itemBill b)
        {
            List<itemBill> list2 = new List<itemBill>();
            if (listSplit.Count != 0)
            {
                int sl = 0;
                foreach (var item in listSplit)
                {
                    if (item.productid == b.productid)
                    {
                        item.slMenu++;
                        list2.Add(item);
                        sl = 1;
                    }
                    else
                    {
                        list2.Add(item);
                    }
                }
                if (sl == 0)
                {
                    list2.Add(b);
                }
                listSplit = list2;
            }
            else
            {
                listSplit.Add(b);
            }

        }
        void Split(int pid)
        {
            List < itemBill> list2 = new List<itemBill>();
            foreach (var item in listRoot) //duyệt list cũ
            {
                if (item.productid == pid)
                {
                    if(item.slMenu > 1)
                    {
                        item.slMenu--;
                        list2.Add(item);
                    }
                    itemBill splitItem = new itemBill();
                    splitItem.productid = pid;
                    splitItem.nameMenu = item.nameMenu;
                    splitItem.slMenu = 1;
                    addSplit(splitItem); //add vô list tách
                }
                else
                {
                    list2.Add(item);
                }
            }
            listRoot = list2; //tạo ra list mới đã trừ số lượng
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (listRoot.Count == 0)
            {
                MessageBox.Show("Bạn không được để hóa đơn gốc trống!Vui lòng chỉnh sửa và thử lại!","Lỗi trống hóa đơn gốc!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(listSplit.Count == 0)
                {
                    MessageBox.Show("Hóa đơn tách đang trống! Vui lòng thêm món!","Trống hóa đơn!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    billDAO dao = new billDAO();
                    int billsplit = dao.createBillSplit(Staffid, billCur.Bill_Table, billCur.Bill_TimeFrom, listSplit);
                    Checkout_GUI checkout = new Checkout_GUI(billsplit, false, new staffDAO().getStaff(Staffid), true);
                    this.Close();
                    checkout.ShowDialog();
                    ChooseTable_GUI choose = new ChooseTable_GUI(new staffDAO().getStaff(Staffid));
                    choose.ShowDialog();
                }
            }
        }
    }
}