﻿using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    internal class menuDAO
    {
        public List<Product> getListMenu()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Product> list = db.Products.ToList();
                return list;
            }
        }

        public List<Product> getListMenubyGenre(int cate)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Product> list = db.Products.Where( p => p.Product_Category == cate && p.Product_isActive==true).ToList();
                return list;
            }
        }
        public Product searchbyName(string Name)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var pro = db.Products.Where(p => p.Product_Name == Name && p.Product_isActive == true).FirstOrDefault();
                return pro;
            }
        }

        public Product getProductbyID(int id)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var pr = db.Products.Where(p => p.Product_ID == id && p.Product_isActive == true).FirstOrDefault();
                return pr;
            }
        }

        public Category GetCategory(int id)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var cate = db.Categories.Where(c => c.Category_ID == id).FirstOrDefault();
                return cate;
            }
        }
        public List<Product> find50(String name)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Product> list = db.Products.Where(p => p.Product_Name.Contains(name)).ToList();
                return list;
            }
        }

        public List<Recipe> getRecipe(int pid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Recipe> list = db.Recipes.Where(r => r.Recipe_Product == pid).ToList();
                return list;
            }
        }
    }
}
