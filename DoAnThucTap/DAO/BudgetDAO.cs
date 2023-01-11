using DevExpress.Printing.Core.PdfExport.Metafile;
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
        public List<Discount> getFullListDiscount()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Discounts.ToList();
            }
        }
        public void addDiscount(Discount discount) 
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.Discounts.Add(discount);
                db.SaveChanges();
            }
        }

        public void updateDiscount(Discount discount) 
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var dis2 = db.Discounts.Where(d => d.Discount_ID == discount.Discount_ID).FirstOrDefault();
                dis2.Discount_Per = discount.Discount_Per;
                dis2.Discount_name = discount.Discount_name;
                dis2.Discount_allProduct = discount.Discount_allProduct;
                db.Entry(dis2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void deleteDiscount(int disID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var dis2 = db.Discounts.Where(d => d.Discount_ID == disID).FirstOrDefault();
                dis2.Discount_DateEnd = DateTime.Now;
                db.Entry(dis2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void restoreDiscount(int disID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var dis2 = db.Discounts.Where(d => d.Discount_ID == disID).FirstOrDefault();
                dis2.Discount_DateStart = DateTime.Now;
                dis2.Discount_DateEnd = null;
                db.Entry(dis2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Discount getDiscount(int disID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Discounts.Where(d => d.Discount_ID == disID).FirstOrDefault();
            }
        }
    }
}
