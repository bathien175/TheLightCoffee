using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    internal class tableBill
    {
        public DBTable dbtable { get; set; }
        public int BillQuantity { get; set;}
        public DateTime BillTime { get; set;}
    }
}
