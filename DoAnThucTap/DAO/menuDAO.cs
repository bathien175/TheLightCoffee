using DoAnThucTap.DTO;
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
    }
}
