using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class SurchargeDTO
    {
        public int Surcharge_ID { get; set; }
        public String Surcharge_Name { get; set; }
        public long Surcharge_Price { get; set; }
        public String Surcharge_DateStart { get; set; }
        public String Surcharge_DateEnd { get; set; }
    }
}
