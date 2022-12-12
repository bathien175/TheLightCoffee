using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class billnoTakeAway : billIsTakeAway
    {
        public String Bill_Table { get; set; }
        public DateTime Bill_TimeFrom { get; set; }
        public DateTime Bill_TimeTo { get;set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
