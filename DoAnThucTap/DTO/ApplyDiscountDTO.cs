using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.DTO
{
    public class ApplyDiscountDTO
    {
        public int Product_ID {get; set;}
        public String Product_Name {get; set;}
        public String Product_Unit { get; set;}
        public long Product_Price {get; set;}
    }
}
