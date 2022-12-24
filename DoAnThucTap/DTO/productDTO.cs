using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class productDTO
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public Image Product_Image { get; set; }
        public String Product_Category { get; set; }
        public String Product_Unit { get; set; }
        public String Product_Price { get; set; }
        public String Product_isActive { get; set; }
    }
}
