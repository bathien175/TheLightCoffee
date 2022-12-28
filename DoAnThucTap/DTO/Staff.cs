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
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Bills = new HashSet<Bill>();
            this.Imports = new HashSet<Import>();
            this.Payments = new HashSet<Payment>();
            this.receipts = new HashSet<receipt>();
        }
    
        public string Staff_Code { get; set; }
        public string Staff_Name { get; set; }
        public Nullable<System.DateTime> Staff_Datebirth { get; set; }
        public string Staff_Gender { get; set; }
        public string Staff_Phone { get; set; }
        public string Staff_Address { get; set; }
        public string Staff_Password { get; set; }
        public bool Staff_isAdmin { get; set; }
        public bool Staff_isActive { get; set; }
        public byte[] Staff_Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<receipt> receipts { get; set; }
    }
}
