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
    
    public partial class receipt
    {
        public int receipt_ID { get; set; }
        public string receipt_name { get; set; }
        public Nullable<System.DateTime> receipt_time { get; set; }
        public string receipt_Staff { get; set; }
        public Nullable<long> receipt_money { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}