//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Target
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLine
    {
        public int Id { get; set; }
        public Nullable<int> OrderLineProductId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
