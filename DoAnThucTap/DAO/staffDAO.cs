using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    internal class staffDAO
    {
        public Staff getStaff(String staffId)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.Staffs.Where(staff => staff.Staff_Code==staffId && staff.Staff_isActive==true).FirstOrDefault();
                return s;
            }
        }

        public void EditImageStaff(String fileName,String staff_code)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.Staffs.Where(staff => staff.Staff_Code == staff_code && staff.Staff_isActive == true).FirstOrDefault();
                if (s != null)
                {
                    s.Staff_Image = fileName;
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        public void EditPasswordStaff(String newpassword, String staff_code)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.Staffs.Where(staff => staff.Staff_Code == staff_code && staff.Staff_isActive == true).FirstOrDefault();
                if (s != null)
                {
                    s.Staff_Password = newpassword;
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    } 
}
