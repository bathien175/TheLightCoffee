using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    internal class billIsTakeAway
    {
        public int Bill_Code { get; set; }
        public String Bill_Staff { get; set; }
        public String Bill_Product { get; set; }
        public int Bill_Quantity { get; set; }
        public long Bill_UnitPrice { get; set; }
        public long Bill_ExtraFee { get; set; }
        public long Bill_Discount { get; set; }
        public long Bill_TotalMoney { get; set; }
    }
}
