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
    
    public partial class Recipe
    {
        public int Recipe_ID { get; set; }
        public string Recipe_Info { get; set; }
        public int Recipe_Product { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
