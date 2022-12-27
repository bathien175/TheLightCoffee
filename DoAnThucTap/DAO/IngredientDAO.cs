using DevExpress.Xpo.Helpers;
using DoAnThucTap.DTO;
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
        public void ImportSingle(String staffCode,int ingreId, int sl)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Ingredient ingre = db.Ingredients.Where(i => i.Ingredient_ID==ingreId).FirstOrDefault();
                //tạo phiếu nhập
                Import im = new Import();
                im.Import_Staff = staffCode;
                im.Import_Date = DateTime.Now;
                im.Import_TotalMoney = ingre.Ingredient_PriceImport * sl;
                db.Imports.Add(im);
                db.SaveChanges();
                //tạo chi tiết phiếu
                Import_Info info = new Import_Info();
                info.Import_ID = im.Import_ID;
                info.Info_Quantity= sl;
                info.Info_Ingredient= ingreId;
                db.Import_Info.Add(info);
                db.SaveChanges();
                //cập nhật số lượng
                ingre.Ingredient_Reserved += sl;
                db.Entry(ingre).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<exportIImport_Result> ImportMultip (String staffCode, List<detailImport> list)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                ///tạo bill
                Import im = new Import();
                im.Import_Staff = staffCode;
                im.Import_Date = DateTime.Now;
                long total = 0;
                foreach (var item in list)
                {
                    long money = item.ingredient.Ingredient_PriceImport * item.sl;
                    total += money;
                }
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
                    db.Import_Info.Add(importin);
                    db.SaveChanges() ;

                    //cập nhạt số lượng trong kho
                    Ingredient x = db.Ingredients.Where(a => a.Ingredient_ID == item.ingredient.Ingredient_ID).FirstOrDefault();
                    if (x != null)
                    {
                        x.Ingredient_Reserved += item.sl;
                        db.Entry(x).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                //trả dữ liệu phiếu nhập ra
                var result = db.exportIImport(im.Import_ID).ToList();
                return result;
            }
        }
    }
}
