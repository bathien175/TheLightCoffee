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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.Bill_Info = new HashSet<Bill_Info>();
            this.Surcharges = new HashSet<Surcharge>();
        }
    
        public int Bill_ID { get; set; }
        public string Bill_Table { get; set; }
        public string Bill_Staff { get; set; }
        public System.DateTime Bill_TimeFrom { get; set; }
        public Nullable<System.DateTime> Bill_TimeTo { get; set; }
        public long Bill_Discount { get; set; }
        public bool Bill_isTakeAway { get; set; }
        public long Bill_TotalMoney { get; set; }
        public bool Bill_Status { get; set; }
        public Nullable<long> Bill_ExtraFee { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Info> Bill_Info { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual DBTable DBTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Surcharge> Surcharges { get; set; }
    }
}