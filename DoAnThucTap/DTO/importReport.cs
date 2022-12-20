using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class importReport
    {
        public int Import_ID { get; set; }
        public DateTime Import_Date { get; set; }
        public String Import_Staff { get; set; }
        public String Import_Ingredient { get; set; }
        public int Import_Quantity { get; set; }
        public String Import_Unit { get; set; }
        public long Import_Price { get; set; }
        public long Import_TotalMoney { get; set; }
    }
}
