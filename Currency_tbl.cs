//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cash_prg
{
    using System;
    using System.Collections.Generic;
    
    public partial class Currency_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Currency_tbl()
        {
            this.Company_tbl = new HashSet<Company_tbl>();
            this.Purchase_order_tbl = new HashSet<Purchase_order_tbl>();
            this.Sales_Estimate_tbl = new HashSet<Sales_Estimate_tbl>();
            this.Vendors_tbl = new HashSet<Vendors_tbl>();
        }
    
        public int Id { get; set; }
        public string Currency_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_tbl> Company_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_order_tbl> Purchase_order_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Estimate_tbl> Sales_Estimate_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendors_tbl> Vendors_tbl { get; set; }
    }
}
