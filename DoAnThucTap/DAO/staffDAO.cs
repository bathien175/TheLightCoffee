using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Staff findStaff(String Staffid)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.Staffs.Where(staff => staff.Staff_Code == Staffid).FirstOrDefault();
                return s;
            }
        }
        public void EditImageStaff(byte[] fileName,String staff_code)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                var s = db.Staffs.Where(staff => staff.Staff_Code == staff_code).FirstOrDefault();
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
                var s = db.Staffs.Where(staff => staff.Staff_Code == staff_code).FirstOrDefault();
                if (s != null)
                {
                    s.Staff_Password = newpassword;
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        public List<Staff> getFullListStaff()
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                List<Staff> list = db.Staffs.Where(n => n.Staff_Code != "admin").ToList();
                return list;
            }
        }
        public bool AddStaff(Staff s)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                if(db.Staffs.Where(n => n.Staff_Code == s.Staff_Code) != null)
                {
                    db.Staffs.Add(s);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!","Lỗi trùng lặp!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
                
            }
        }
        public void updateStaff(Staff s)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Staff staff = db.Staffs.Where(st => st.Staff_Code == s.Staff_Code).FirstOrDefault();
                staff.Staff_Name= s.Staff_Name;
                staff.Staff_Phone = s.Staff_Phone;
                staff.Staff_Gender = s.Staff_Gender;
                staff.Staff_Address = s.Staff_Address;
                staff.Staff_Datebirth= s.Staff_Datebirth;
                staff.Staff_Image= s.Staff_Image;
                db.SaveChanges();
            }
        }
        public void deleteStaff(String s)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Staff staff = db.Staffs.Where(st => st.Staff_Code == s).FirstOrDefault();
                staff.Staff_isActive= false;
                db.SaveChanges();
            }
        }
        public void restoreStaff(String s)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Staff staff = db.Staffs.Where(st => st.Staff_Code == s).FirstOrDefault();
                staff.Staff_isActive = true;
                db.SaveChanges();
            }
        }
    } 
}
