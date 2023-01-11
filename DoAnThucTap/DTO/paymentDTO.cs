using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class paymentDTO
    {
        public int payment_ID { get; set; }
        public string payment_name { get; set; }
        public DateTime payment_time { get; set; }
        public string payment_staff { get; set; }
        public long payment_money { get; set; }
    }
}
