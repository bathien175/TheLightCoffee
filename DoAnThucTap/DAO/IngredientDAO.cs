using DevExpress.Xpo.Helpers;
using DoAnThucTap.DTO;
using DoAnThucTap.userControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    internal class IngredientDAO
    {
        public void updateFullIngredient(List<item_updateIngredient> list)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                foreach (var item in list)
                {
                    var i = db.Ingredients.Where(x => x.Ingredient_ID == item.getIDIngredient).FirstOrDefault();
                    i.Ingredient_Reserved = item.getQuantity;
                    db.Entry(i).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        public List<Ingredient> getFullIngredient()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Ingredients.Where(i => i.Ingredient_isActive == true).ToList();
            }
        }
        public List<Ingredient> getFullIngredient2()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Ingredients.ToList();
            }
        }
        public void addIngredient(Ingredient i)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                db.Ingredients.Add(i);
                db.SaveChanges();
            }
        }
        public void updateIngredient(Ingredient i)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Ingredient i2 = db.Ingredients.Where(ingre => ingre.Ingredient_ID==i.Ingredient_ID).FirstOrDefault();
                i2.Ingredient_Name= i.Ingredient_Name;
                i2.Ingredient_PriceImport = i.Ingredient_PriceImport;
                i2.Ingredient_Unit = i.Ingredient_Unit;
                i2.Ingredient_Image= i.Ingredient_Image;
                db.SaveChanges();
            }
        }
        public Ingredient getIngredientbyID(int id)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Ingredients.Where(i => i.Ingredient_ID == id).FirstOrDefault();
            }
        }
        public void deleteIngredient(int iid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Ingredient i2 = db.Ingredients.Where(ingre => ingre.Ingredient_ID == iid).FirstOrDefault();
                i2.Ingredient_isActive = false;
                db.SaveChanges();
            }
        }
        public void restoreIngredient(int iid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Ingredient i2 = db.Ingredients.Where(ingre => ingre.Ingredient_ID == iid).FirstOrDefault();
                i2.Ingredient_isActive = true;
                db.SaveChanges();
            }
        }

        public List<Ingredient> findIngredient(string textfind)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Ingredient> list = db.Ingredients.Where(i=> i.Ingredient_isActive==true && i.Ingredient_Name.Contains(textfind)).ToList();
                return list;
            }
        }
        public Ingredient searchIngredientbyID(int id)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Ingredients.Where(i => i.Ingredient_ID==id && i.Ingredient_isActive == true).FirstOrDefault();
            }
        }
        public Ingredient searchByName(String name)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Ingredients.Where(i => i.Ingredient_Name==name &&i.Ingredient_isActive==true).FirstOrDefault();
            }
        }
        public long getbudget(String s)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<exportDatebyStaff_Result> list = db.exportDatebyStaff(s).ToList();
                if (list.Count == 0)
                {
                    return 0;
                }
                else
                {
                    long total = 0;
                    foreach (var item in list)
                    {
                        if (item.TypeExport == 2)
                        {
                            total -= Convert.ToInt64(item.MoneyExport);
                        }
                        else
                        {
                            total+= Convert.ToInt64(item.MoneyExport);
                        }
                    }
                    return total;
                }
            }
        }
        public bool ImportSingle(String staffCode,int ingreId, int sl, long price)
        {
            long budget = getbudget(staffCode);
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Ingredient ingre = db.Ingredients.Where(i => i.Ingredient_ID==ingreId).FirstOrDefault();
                if(budget< (ingre.Ingredient_PriceImport * sl))
                {
                    return false;
                }
                else
                {
                    //tạo phiếu nhập
                    Import im = new Import();
                    im.Import_Staff = staffCode;
                    im.Import_Date = DateTime.Now;
                    im.Import_TotalMoney = price * sl;
                    db.Imports.Add(im);
                    db.SaveChanges();
                    //tạo chi tiết phiếu
                    Import_Info info = new Import_Info();
                    info.Import_ID = im.Import_ID;
                    info.Info_Quantity = sl;
                    info.Info_Ingredient = ingreId;
                    info.info_Price = price;
                    db.Import_Info.Add(info);
                    db.SaveChanges();
                    //cập nhật số lượng
                    ingre.Ingredient_Reserved += sl;
                    db.Entry(ingre).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    //cập nhật phiếu chi
                    Payment p = new Payment();
                    p.Payment_Staff = staffCode;
                    p.Payment_name = "Nhập '" + ingre.Ingredient_Name + "', SL = " + sl.ToString();
                    p.Payment_time = DateTime.Now;
                    p.Payment_money = price * sl;
                    db.Payments.Add(p);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public List<exportIImport_Result> ImportMultip (String staffCode, List<detailImport> list)
        {
            long budget = getbudget(staffCode);
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                long total = 0;
                foreach (var item in list)
                {
                    double check = Math.Ceiling(Math.Round((Convert.ToDouble(item.Price * item.sl) / 1000), 1));
                    long money = Convert.ToInt64(check * 1000);
                    total += money;
                }
                if (total > budget)
                {
                    return new List<exportIImport_Result>();
                }
                else
                {
                    ///tạo bill
                    Import im = new Import();
                    im.Import_Staff = staffCode;
                    im.Import_Date = DateTime.Now;
                    im.Import_TotalMoney = total;
                    db.Imports.Add(im);
                    db.SaveChanges();
                    // tạo chi tiết nhập
                    foreach (var item in list)
                    {
                        Import_Info importin = new Import_Info();
                        importin.Import_ID = im.Import_ID;
                        importin.Info_Ingredient = item.ingredient.Ingredient_ID;
                        importin.Info_Quantity = item.sl;
                        importin.info_Price = item.Price;
                        db.Import_Info.Add(importin);
                        db.SaveChanges();

                        //cập nhạt số lượng trong kho
                        Ingredient x = db.Ingredients.Where(a => a.Ingredient_ID == item.ingredient.Ingredient_ID).FirstOrDefault();
                        if (x != null)
                        {
                            x.Ingredient_Reserved += item.sl;
                            db.Entry(x).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    //tạo phiếu chi
                    Payment p = new Payment();
                    p.Payment_Staff = staffCode;
                    p.Payment_time = DateTime.Now;
                    p.Payment_name = "Phiếu nhập hàng số " + im.Import_ID.ToString();
                    p.Payment_money = total;
                    db.Payments.Add(p);
                    db.SaveChanges();
                    //trả dữ liệu phiếu nhập ra
                    var result = db.exportIImport(im.Import_ID).ToList();
                    return result;
                } 
            }
        }
    }
}
