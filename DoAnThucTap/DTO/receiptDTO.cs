using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class receiptDTO
    {
        public int receipt_ID { get; set; }
        public string receipt_name { get;set; }
        public string receipt_type { get; set; }
        public DateTime receipt_time { get; set; }
        public string receipt_staff { get; set; }
        public long receipt_money { get; set; }
    }
}
