using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class billDTO
    {
        public int Bill_ID { get; set; }
        public String Bill_Type { get; set; }
        public String Bill_Table { get; set; }
        public String Bill_Staff { get; set; }
        public DateTime Bill_DateStart { get; set; }
        public DateTime Bill_DateEnd { get; set; }
        public long Bill_Discount { get; set; }
        public long Bill_Surchange { get;set; }
        public long Bill_TotalMoney{ get; set; }
    }
}
