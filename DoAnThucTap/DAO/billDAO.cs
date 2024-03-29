﻿using DevExpress.Utils.About;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DoAnThucTap.DTO;
using DoAnThucTap.userControl;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.DAO
{
    internal class billDAO
    {
        //String connectStr = @"Data Source=192.168.1.13,1433;Initial Catalog=TheLightCoffee;Persist Security Info=True;User ID=sa;Password=sa;MultipleActiveResultSets=True;Application Name=EntityFramework";
        public Bill getBillbyTableID(String tableID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var b = db.Bills.Where(bill => bill.Bill_Table==tableID && bill.Bill_Status==false).FirstOrDefault();
                return b;
            }
        }
        public List<exportDate_Result> GetExportDate_Results()
        {
            List<exportDate_Result> list = new List<exportDate_Result>();
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                list = db.exportDate().ToList();
                return list;
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
        public void checkOut(String staff,int BillID, long discount, long extra, long totalMoney)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill bill = db.Bills.Where(b => b.Bill_ID == BillID).FirstOrDefault();
                bill.Bill_TimeTo = DateTime.Now;
                bill.Bill_Status = true;
                bill.Bill_Discount = discount;
                bill.Bill_TotalMoney = totalMoney;
                bill.Bill_ExtraFee = extra;
                db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges(); //cap nhat bill
                if (bill.Bill_isTakeAway == false)
                {
                    DBTable tb = db.DBTables.Where(t => t.Table_Code == bill.Bill_Table).First();
                    tb.Table_Status = 0;
                    db.Entry(tb).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges(); //cap nhat table
                }
                //tạo phiếu thu
                receipt r = new receipt();
                r.receipt_Staff = staff;
                r.receipt_time = DateTime.Now;
                r.receipt_name = "Thanh toán hóa đơn số "+ bill.Bill_ID.ToString();
                r.receipt_isMoneyImport = false;
                r.receipt_money = totalMoney;
                db.receipts.Add(r);
                db.SaveChanges();
            }
        }
        public void checkOutSplit(String staff,int BillID, long discount, long extra, long totalMoney)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill bill = db.Bills.Where(b => b.Bill_ID == BillID).FirstOrDefault();
                bill.Bill_TimeTo = DateTime.Now;
                bill.Bill_Status = true;
                bill.Bill_Discount = discount;
                bill.Bill_TotalMoney = totalMoney;
                bill.Bill_ExtraFee = extra;
                db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges(); //cap nhat bill
                //tạo phiếu thu
                receipt r = new receipt();
                r.receipt_Staff = staff;
                r.receipt_time = DateTime.Now;
                r.receipt_name = "Thanh toán hóa đơn số " + bill.Bill_ID.ToString();
                r.receipt_isMoneyImport = false;
                r.receipt_money = totalMoney;
                db.receipts.Add(r);
                db.SaveChanges();
            }
        }
        public void addSurchange(int billid, int surchangeID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.addSurchange(billid, surchangeID);
                db.SaveChanges();
            }
        }
        public bool checkStatusBill(int billid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                 var b =  db.Bills.Where(bill => bill.Bill_ID == billid).FirstOrDefault();
                if (b.Bill_Status == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void removeSurchange(int billid, int surchangeID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.removeSurchange(billid, surchangeID);
                db.SaveChanges();
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
        public Bill getBill(int billid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Bills.Where(b => b.Bill_ID ==billid).FirstOrDefault();
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
        public void restoreBillOld(int billid,List<Bill_Info> list)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill bold = getBill(billid);
                List<Bill_Info> listold = db.Bill_Info.Where(bi => bi.BI_Bill == bold.Bill_ID).ToList();
                foreach (var item in list)
                {
                    bool isFind = false;
                    foreach (var i in listold)
                    {
                        if (i.BI_Product == item.BI_Product)
                        {
                            i.BI_Quantity += item.BI_Quantity;
                            db.Entry(i).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            isFind = true;break;
                        }
                    }
                    if (!isFind)
                    {
                        Bill_Info bi = new Bill_Info();
                        bi.BI_Bill = billid;
                        bi.BI_Product = item.BI_Product;
                        bi.BI_Quantity = item.BI_Quantity;
                        db.Bill_Info.Add(bi);
                        db.SaveChanges();
                    }
                }
            }
        }
        public void removeBillSplit(int Bill_ID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill bnew = getBill(Bill_ID);
                List<Bill_Info> listnew = db.Bill_Info.Where(bi => bi.BI_Bill == bnew.Bill_ID).ToList();
                //phục hồi bill cũ
                var billold = db.Bills.Where(x => x.Bill_Table == bnew.Bill_Table && x.Bill_Status == false && x.Bill_ID != bnew.Bill_ID).FirstOrDefault();
                restoreBillOld(billold.Bill_ID, listnew);
                //xóa bill đã tách
                db.removeFullSurchange(bnew.Bill_ID);
                foreach (Bill_Info item in listnew)
                {
                    db.Bill_Info.Remove(item);
                    db.SaveChanges();
                }
                db.Bills.Attach(bnew);
                db.Entry(bnew).State = EntityState.Deleted;
                db.Bills.Remove(bnew);
                db.SaveChanges();
            }
        }
        public int createBillSplit(String staffId,String tableID, DateTime timefrom,List<itemBill> listdata)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                try
                {
                    //quá trình caajap nhật bill cũ
                    Bill b = getBillbyTableID(tableID);
                    List<Bill_Info> listbillold = db.Bill_Info.Where(x => x.BI_Bill == b.Bill_ID).ToList();
                    foreach (var item in listbillold)
                    {
                        foreach (var i in listdata)
                        {
                            if(item.BI_Product == i.productid)
                            {
                                if (item.BI_Quantity > i.slMenu)
                                {
                                    item.BI_Quantity -= i.slMenu;
                                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                }
                                else
                                {
                                    db.Bill_Info.Remove(item);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                    //tạo bill tách mới
                    Bill bill = new Bill();
                    bill.Bill_Table = tableID;
                    bill.Bill_Status = false;
                    bill.Bill_TotalMoney = 0;
                    bill.Bill_Staff = staffId;
                    bill.Bill_TimeFrom = timefrom;
                    bill.Bill_Discount = 0;
                    bill.Bill_ExtraFee = 0;
                    bill.Bill_TimeTo = null;
                    bill.Bill_isTakeAway = false;
                    db.Bills.Add(bill);
                    db.SaveChanges();
                    //add món
                    foreach (var item in listdata)
                    {
                        Bill_Info bi = new Bill_Info();
                        bi.BI_Bill = bill.Bill_ID;
                        bi.BI_Quantity = item.slMenu;
                        bi.BI_Product = item.productid;
                        db.Bill_Info.Add(bi);
                        db.SaveChanges();
                    }
                    return bill.Bill_ID;
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra!Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
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
                    db.removeFullSurchange(bill.Bill_ID);
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

        public void switchTable(String tbCurr, String tbSwitch)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var bill = db.Bills.Where(b => b.Bill_Table== tbSwitch && b.Bill_Status == false).FirstOrDefault();
                if (bill == null) //chuyển bàn
                {
                    var billcur = db.Bills.Where(b => b.Bill_Table == tbCurr && b.Bill_Status == false).FirstOrDefault();
                    billcur.Bill_Table= tbSwitch;
                    db.Entry(billcur).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    var tbCur = db.DBTables.Where(tb => tb.Table_Code == tbCurr && tb.isActive==true).FirstOrDefault();
                    tbCur.Table_Status = 0;
                    db.Entry(tbCur).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    var tbSw = db.DBTables.Where(tb => tb.Table_Code == tbSwitch && tb.isActive == true).FirstOrDefault();
                    tbSw.Table_Status = 1;
                    db.Entry(tbSw).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else //gộp bàn
                {
                    var tbCur = db.DBTables.Where(tb => tb.Table_Code == tbCurr && tb.isActive == true).FirstOrDefault();
                    tbCur.Table_Status = 0;
                    db.Entry(tbCur).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    Bill billcur = db.Bills.Where(b => b.Bill_Table== tbCurr && b.Bill_Status==false).First();
                    List<Bill_Info> listbillcur = db.Bill_Info.Where(b=> b.BI_Bill==billcur.Bill_ID).ToList();

                    Bill billSwitch = db.Bills.Where(b => b.Bill_Table == tbSwitch && b.Bill_Status == false).First();
                    List<Bill_Info> listbillswitch = db.Bill_Info.Where(b => b.BI_Bill == billSwitch.Bill_ID).ToList();
                    foreach (Bill_Info item in listbillcur)
                    {
                        bool exsist = false;
                        foreach (Bill_Info item2 in listbillswitch)
                        {
                            if (item.BI_Product == item2.BI_Product) // món đã có trong bill 
                            {
                                item2.BI_Quantity += item.BI_Quantity; // cộng thêm số lượng món bên bill chuyển qua
                                db.Entry(item2).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                db.Bill_Info.Remove(item); // dồn dô bill info bên bàn chuyển thì ta xóa bill info hiện tại đi
                                db.SaveChanges();

                                exsist= true;
                                break;
                            }
                            else 
                            {
                               exsist= false;
                            }
                        }
                        if (!exsist) //món chưa có thì ta thêm vào (update mã bill sang mã bill bàn mình chuyển vào)
                        {
                            item.BI_Bill = billSwitch.Bill_ID;
                            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    db.Bills.Remove(billcur); // xóa bill của bàn hiện tại đi
                    db.SaveChanges();
                }
            }
        }

        public void editQuantityBillinfo(int billid,int pid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill_Info bi = db.Bill_Info.Where(b => b.BI_Bill==billid&&b.BI_Product==pid).FirstOrDefault();
                if (bi!=null)
                {
                    if(bi.BI_Quantity==1) // chỉ có 1 thì xóa
                    {
                        db.Bill_Info.Remove(bi);
                        db.SaveChanges() ;
                    }
                    else //nếu lớn hơn 1 thì ta trừ 1 số lượng
                    {
                        bi.BI_Quantity--;
                        db.Entry(bi).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }   
                }
            }
        }
        public void removeQuantityBillinfo(int billid, int pid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Bill_Info bi = db.Bill_Info.Where(b => b.BI_Bill == billid && b.BI_Product == pid).FirstOrDefault();
                db.Bill_Info.Remove(bi);
                db.SaveChanges();
            }
        }

        public List<Bill> getFullListBill()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Bills.ToList();
            }
        }
        public List<Import> getFullListImport()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Imports.ToList();
            }
        }
        public List<receipt> getFullListReceipt()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.receipts.ToList();
            }
        }
        public List<Payment> getFullListPayment()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Payments.ToList();
            }
        }
    }
}
