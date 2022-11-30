using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DAO
{
    internal class LoginDAO
    {
        public Staff Login(String staffcode, String password, bool admin)
        {
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                Staff staff = new Staff();
                if (admin == false)
                {
                    staff = db.Staffs.Where(s => s.Staff_Code == staffcode && s.Staff_Password == password && s.Staff_isActive==true).FirstOrDefault();
                }
                else
                {
                    staff = db.Staffs.Where(s => s.Staff_Code == staffcode && s.Staff_Password == password && s.Staff_isActive == true && s.Staff_isAdmin==true).FirstOrDefault();
                }
                
                if (staff != null)
                {
                    return staff;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
