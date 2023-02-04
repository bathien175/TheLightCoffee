using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    internal class tableDAO
    {

        public List<tableBill> getTablehaveBill()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<tableBill> listTableBill = new List<tableBill>();
                List<DBTable> list = db.DBTables.Where(t => t.Table_Status == 1 || t.Table_Status == 2).ToList();
                foreach (DBTable item in list)
                {
                    tableBill tb = new tableBill();
                    tb.dbtable = item;
                    if(item.Table_Status == 1) 
                    {
                        var bid = db.Bills.Where(b => b.Bill_Table == item.Table_Code && b.Bill_Status == false).FirstOrDefault();
                        tb.BillQuantity = db.Bill_Info.Count(bif => bif.BI_Bill == bid.Bill_ID);
                        tb.BillTime = bid.Bill_TimeFrom;
                    }
                    listTableBill.Add(tb);
                }
                return listTableBill;
            }
        }

        public List<DBTable> getFullTable()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<DBTable> list = db.DBTables.Where(t => t.isActive == true).ToList();
                return list;
            }
        }

        public List<DBTable> getFullListTable()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<DBTable> list = db.DBTables.ToList();
                return list;
            }
        }

        public List<tableBill> getTablebyLocation(String locate)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<tableBill> listTableBill = new List<tableBill>();
                List<DBTable> list = db.DBTables.Where(t => t.Table_Location == locate && t.isActive==true).ToList();
                foreach (DBTable item in list)
                {
                    tableBill tb = new tableBill();
                    tb.dbtable = item;
                    var bid = db.Bills.Where(b => b.Bill_Table == item.Table_Code && b.Bill_Status == false).FirstOrDefault();
                    if(bid != null)
                    {
                        tb.BillQuantity = db.Bill_Info.Count(bif => bif.BI_Bill == bid.Bill_ID);
                        tb.BillTime = bid.Bill_TimeFrom;
                    }
                    else
                    {
                        tb.BillQuantity = 0;
                    }
                    
                    listTableBill.Add(tb);
                }
                return listTableBill;
            }
        }
        public DBTable getTableByID(String tableId)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.DBTables.Where(t => t.Table_Code == tableId).FirstOrDefault();
            }
        }
        public int checkStatusTable(String tableCode)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                DBTable tb = db.DBTables.Where(t => t.Table_Code == tableCode).FirstOrDefault();
                if (tb != null)
                {
                    return tb.Table_Status;
                }
                else
                {
                    return -1;
                }
            }
        }

        public void bookingTable(String tableID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var t = db.DBTables.Where(b => b.Table_Code == tableID && b.isActive == true).FirstOrDefault();
                t.Table_Status = 2;
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges(); //cap nhat table
            }
        }
        public List<DBTable> listTableSwitch(String tableid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<DBTable> list = db.DBTables.Where(t => t.Table_Code != tableid && t.isActive == true && t.Table_Status!=2).ToList();
                return list;
            }
        }
        public void cancelbookingTable(String tableID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var t = db.DBTables.Where(b => b.Table_Code == tableID && b.isActive == true).FirstOrDefault();
                t.Table_Status = 0;
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges(); //cap nhat table
            }
        }

        public void addTable(DBTable t)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.DBTables.Add(t);
                db.SaveChanges();
            }
        }

        public void updateTable(DBTable t)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var t2 = db.DBTables.Where(x =>x.Table_Code==t.Table_Code).FirstOrDefault();
                t2.Table_Location = t.Table_Location;
                db.Entry(t2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void deleteTable(String t)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var t2 = db.DBTables.Where(x => x.Table_Code == t).FirstOrDefault();
                t2.isActive = false;
                db.Entry(t2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void restoreTable(String t)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var t2 = db.DBTables.Where(x => x.Table_Code == t).FirstOrDefault();
                t2.isActive = true;
                db.Entry(t2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public bool checkExistCode(String t)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var t2 = db.DBTables.Where(x => x.Table_Code == t).FirstOrDefault();
                if (t2 != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
