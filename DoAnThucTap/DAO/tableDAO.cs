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
                    var bid = db.Bills.Where(b => b.Bill_Table == item.Table_Code && b.Bill_Status == false).FirstOrDefault();
                    tb.BillQuantity = db.Bill_Info.Count(bif => bif.BI_Bill == bid.Bill_ID);
                    listTableBill.Add(tb);
                }
                return listTableBill;
            }
        }

        public List<DBTable> getFullTable()
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
                List<DBTable> list = db.DBTables.Where(t => t.Table_Location == locate).ToList();
                foreach (DBTable item in list)
                {
                    tableBill tb = new tableBill();
                    tb.dbtable = item;
                    var bid = db.Bills.Where(b => b.Bill_Table == item.Table_Code && b.Bill_Status == false).FirstOrDefault();
                    if(bid != null)
                    {
                        tb.BillQuantity = db.Bill_Info.Count(bif => bif.BI_Bill == bid.Bill_ID);
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
    }
}
