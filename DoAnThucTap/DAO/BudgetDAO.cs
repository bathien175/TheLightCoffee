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
        public List<exportbyDate_Result> getListByDate(DateTime d)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<exportbyDate_Result> list = db.exportbyDate(d.Day,d.Month,d.Year).ToList();
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

        public List<Surcharge> getFullListSurcharge()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Surcharges.ToList();
            }
        }
        public void addSurcharge(Surcharge sur)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.Surcharges.Add(sur);
                db.SaveChanges();
            }
        }

        public void updateSurcharge(Surcharge sur)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var sur2 = db.Surcharges.Where(d => d.Surcharge_ID == sur.Surcharge_ID).FirstOrDefault();
                sur2.Surcharge_Name = sur.Surcharge_Name;
                sur2.Surcharge_Price = sur.Surcharge_Price;
                db.Entry(sur2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void deleteSurcharge(int surID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var sur2 = db.Surcharges.Where(d => d.Surcharge_ID == surID).FirstOrDefault();
                sur2.Surcharge_DateEnd = DateTime.Now;
                db.Entry(sur2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void restoreSurcharge(int surID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var sur2 = db.Surcharges.Where(d => d.Surcharge_ID == surID).FirstOrDefault();
                sur2.Surcharge_DateStart = DateTime.Now;
                sur2.Surcharge_DateEnd = null;
                db.Entry(sur2).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Surcharge getSurcharge(int surID)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Surcharges.Where(d => d.Surcharge_ID ==surID).FirstOrDefault();
            }
        }

    }
}
