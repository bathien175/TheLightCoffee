using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.DAO
{
    internal class menuDAO
    {
        public List<Product> getListMenu()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Product> list = db.Products.Where(x => x.Product_isActive == true).ToList();
                return list;
            }
        }
        public List<Product> getFullListMenu()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Product> list = db.Products.ToList();
                return list;
            }
        }
        public void updateImage(byte[] b)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Product> list = db.Products.ToList();
                foreach (var item in list)
                {
                    item.Product_Image = b;
                    db.SaveChanges();
                }
            }
        }
        public AutoCompleteStringCollection getUnit()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<String> strings = db.Products.Select(p => p.Product_Unit).Distinct().ToList();
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                foreach (var item in strings)
                {
                    auto.Add(item);
                }
                return auto;
            }
        }
        public int getGenreByName(String name)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Categories.Where(g => g.Category_Name == name).FirstOrDefault().Category_ID;
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
        public Product getProductbyIDDeleted(int id)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var pr = db.Products.Where(p => p.Product_ID == id && p.Product_isActive == false).FirstOrDefault();
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
        public List<Category> getListCategory()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Categories.Where(i => i.Category_isActive==true).ToList();
            }
        }
        public List<Category> getFullListCategory()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                return db.Categories.ToList();
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

        public void addMenu(Product p)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                try
                {
                    db.Products.Add(p);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại thông tin trước khi thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public void updateMenu(Product p) 
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                try
                {
                    Product p2 = db.Products.Where(pro => pro.Product_ID==p.Product_ID).FirstOrDefault();
                    p2.Product_Name = p.Product_Name;
                    p2.Product_Image= p.Product_Image;
                    p2.Product_Category= p.Product_Category;
                    p2.Product_Unit= p.Product_Unit;
                    p2.Product_Price= p.Product_Price;
                    p2.Product_Image = p.Product_Image;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại thông tin trước khi thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void deleteMenu(int pid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                try
                {
                    Product p = db.Products.Where(pro => pro.Product_ID==pid).FirstOrDefault();
                    p.Product_isActive = false;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại thông tin trước khi thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void restoreMenu(int pid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                try
                {
                    Product p = db.Products.Where(pro => pro.Product_ID == pid).FirstOrDefault();
                    p.Product_isActive = true;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng kiểm tra lại thông tin trước khi thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool addCategory(Category i)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                if(db.Categories.Where(c => c.Category_Name == i.Category_Name).FirstOrDefault() == null)
                {
                    db.Categories.Add(i);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Phân loại này đã có sẵn trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool updateCategory(Category i)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Category cate = db.Categories.Where(c => c.Category_ID == i.Category_ID).FirstOrDefault();
                var ca = db.Categories.Where(x => x.Category_ID != i.Category_ID && x.Category_Name == i.Category_Name).FirstOrDefault();
                if (ca == null)
                {
                    cate.Category_Name = i.Category_Name;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Phân loại này đã có sẵn trong cơ sở dữ liệu","Lỗi trùng tên!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool deleteCategory(int i)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Category cate = db.Categories.Where(c => c.Category_ID == i).FirstOrDefault();
                if (cate.Category_isActive==true)
                {
                    cate.Category_isActive = false;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Loại này đã được ngưng sử dụng trước đó!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool restoreCategory(int i)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Category cate = db.Categories.Where(c => c.Category_ID == i).FirstOrDefault();
                if(cate.Category_isActive==false)
                {
                    cate.Category_isActive = true;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Loại này vẫn còn sử dụng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public List<Recipe> getfullListRecipe()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Recipe> list = db.Recipes.ToList();
                return list;
            }
        }

        public void AddRecipe(List<Recipe> r)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                foreach (var item in r)
                {
                    db.Recipes.Add(item);
                    db.SaveChanges();
                }
                
            }
        }
        public void updateRecipe(List<Recipe> r)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Recipe> list = db.Recipes.Where(re => re.Recipe_Product == r[0].Recipe_Product).ToList();
                foreach (var item in list)
                {
                    db.Recipes.Remove(item);
                    db.SaveChanges();
                }
                foreach (var item in r)
                {
                    db.Recipes.Add(item);
                    db.SaveChanges();
                }
            }
        }
    }
}
