using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class dateReport
    {
        public String NameExport { get; set; }
        public String ProductExport { get; set; }
        public int QuantityExport { get; set; }
        public String UnitExport { get; set; }
        public long PriceExport { get; set; }
        public long Bill_ExtraFee { get; set; }
        public long Bill_Discount { get; set; }
        public long TotalMoney { get; set; }
        public String type { get; set; }
    }
}
