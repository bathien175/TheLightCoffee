using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.DAO
{
    internal class billDAO
    {
        public Bill getBillbyTableID(String tableID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var b = db.Bills.Where(bill => bill.Bill_Table==tableID && bill.Bill_Status==false).FirstOrDefault();
                return b;
            }
        }

        public List<Bill_Info> getListBillInfo(int billID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var bi = db.Bill_Info.Where(bill => bill.BI_Bill == billID).ToList();
                return bi;
            }
        }
        Bill checkBill(String table)
        {
            using (TheLightCoffeeEntities db  = new TheLightCoffeeEntities())
            {
                var bi = db.Bills.Where(b => b.Bill_Table == table && b.Bill_Status == false).FirstOrDefault();
                return bi;
            }
        }
        Bill_Info checkExistProduct(int productid,int bid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var bi = db.Bill_Info.Where(b => b.BI_Bill == bid && b.BI_Product==productid).FirstOrDefault();
                return bi;
            }
        }
        public void addBillInfo(String table, int productID,int quantity,String staffid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill b = checkBill(table); //tìm bill
                if (b!=null) // nếu bill có tồn tại rồi
                {
                    Bill_Info bi = checkExistProduct(productID, b.Bill_ID);
                    if (bi!=null) // kiểm tra món đã có trong hóa đơn hay chưa
                    {
                        //đã có rồi thì ta đi cập nhật số lượng
                        bi.BI_Quantity += quantity;
                        db.Entry(bi).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else //chưa có món này trong bill thì ta  thêm mới
                    {
                        bi = new Bill_Info();
                        bi.BI_Bill = b.Bill_ID;
                        bi.BI_Product= productID;
                        bi.BI_Quantity= quantity;
                        db.Bill_Info.Add(bi);
                        db.SaveChanges() ;
                    }
                }
                else // bill của bàn chưa tồn tại
                {
                    //tạo bill
                    b = new Bill();
                    b.Bill_Table = table;
                    b.Bill_Status = false;
                    b.Bill_TotalMoney = 0;
                    b.Bill_Staff = staffid;
                    b.Bill_TimeFrom = DateTime.Now;
                    b.Bill_Discount= 0;
                    b.Bill_TimeTo = null;
                    b.Bill_isTakeAway = false;
                    db.Bills.Add(b);
                    db.SaveChanges();
                    //add món vào bill
                    Bill_Info bi = new Bill_Info();
                    bi.BI_Bill = b.Bill_ID;
                    bi.BI_Quantity = quantity;
                    bi.BI_Product = productID;
                    db.Bill_Info.Add(bi);
                    db.SaveChanges();
                    //cap nhật trạng thái bàn
                    DBTable tb = db.DBTables.Where(t => t.Table_Code == table).FirstOrDefault();
                    tb.Table_Status = 1;
                    db.SaveChanges();
                }
            } 
        }

        public void addBillInfoTakeAway(int productID, int quantity, String staffid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill bill = db.Bills.Where(x => x.Bill_isTakeAway==true && x.Bill_Status == false).FirstOrDefault();
                if (bill!=null)
                {
                    Bill_Info bi = checkExistProduct(productID, bill.Bill_ID);
                    if (bi != null) // kiểm tra món đã có trong hóa đơn hay chưa
                    {
                        //đã có rồi thì ta đi cập nhật số lượng
                        bi.BI_Quantity += quantity;
                        db.Entry(bi).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else //chưa có món này trong bill thì ta  thêm mới
                    {
                        bi = new Bill_Info();
                        bi.BI_Bill = bill.Bill_ID;
                        bi.BI_Product = productID;
                        bi.BI_Quantity = quantity;
                        db.Bill_Info.Add(bi);
                        db.SaveChanges();
                    }
                }
                else
                {
                    //tạo bill
                    bill = new Bill();
                    bill.Bill_Table = null;
                    bill.Bill_Status = false;
                    bill.Bill_TotalMoney = 0;
                    bill.Bill_Staff = staffid;
                    bill.Bill_TimeFrom = DateTime.Now;
                    bill.Bill_Discount = 0;
                    bill.Bill_ExtraFee= 0;
                    bill.Bill_TimeTo = null;
                    bill.Bill_isTakeAway = true;
                    db.Bills.Add(bill);
                    db.SaveChanges();
                    //add món
                    Bill_Info bi = new Bill_Info();
                    bi.BI_Bill = bill.Bill_ID;
                    bi.BI_Quantity = quantity;
                    bi.BI_Product = productID;
                    db.Bill_Info.Add(bi);
                    db.SaveChanges();
                }
                
            }
        }
        public Bill getTakeAwayCurrent()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var b = db.Bills.Where(bill => bill.Bill_isTakeAway == true && bill.Bill_Status == false).FirstOrDefault();
                return b;
            }
        }
        public void CancelBillTakeAway()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill bill = db.Bills.Where(b => b.Bill_isTakeAway==true && b.Bill_Status==false).FirstOrDefault();
                if (bill != null)
                {
                    List<Bill_Info> list = db.Bill_Info.Where(bi => bi.BI_Bill == bill.Bill_ID).ToList();
                    foreach (Bill_Info item in list)
                    {
                        db.Bill_Info.Remove(item);
                        db.SaveChanges();
                    }
                    db.Bills.Remove(bill);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống!", "Lỗi phát sinh!");
                }
            }
        }

        public void checkoutTakeAway()
        {

        }
    }
}
