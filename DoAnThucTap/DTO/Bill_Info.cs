//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnThucTap.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_Info
    {
        public int BI_ID { get; set; }
        public int BI_Bill { get; set; }
        public int BI_Product { get; set; }
        public int BI_Quantity { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
