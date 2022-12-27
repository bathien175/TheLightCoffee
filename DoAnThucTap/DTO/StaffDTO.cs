using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class StaffDTO
    {
        public String Staff_ID { get; set; }
        public String Staff_Name { get; set; }
        public String Staff_Datebirth { get; set; }
        public String Staff_Gender { get; set; }
        public String  Staff_Phone {get; set; }
        public String Staff_Address { get; set; }
        public String Staff_isAdmin { get; set; }
        public String Staff_isActive { get; set; }
        public Image Staff_Image { get; set; }
    }
}
