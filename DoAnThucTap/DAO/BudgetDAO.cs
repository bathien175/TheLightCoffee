using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    internal class BudgetDAO
    {
        public List<exportDate_Result> getListDate()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<exportDate_Result> list = db.exportDate().ToList();
                return list;
            }
        }
        public void addPayment(Payment p)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.Payments.Add(p);
                db.SaveChanges();
            }
        }
        public void addReceipts(receipt r)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.receipts.Add(r);
                db.SaveChanges();
            }
        }
    }
}
