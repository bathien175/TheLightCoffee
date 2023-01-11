using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class DiscountDTO
    {
        public int Discount_ID { get; set; }
        public int Discount_Per { get; set; }
        public String Discount_Name { get; set; }
        public String Discount_Type { get; set; }
        public String Discount_DateStart { get; set; }
        public String Discount_DateEnd { get; set; }
    }
}
