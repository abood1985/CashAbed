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
    
    public partial class Payment_method_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment_method_tbl()
        {
            this.Customer_tbl = new HashSet<Customer_tbl>();
            this.Purchase_invoice_tbl = new HashSet<Purchase_invoice_tbl>();
            this.Sales_invoice_tbl = new HashSet<Sales_invoice_tbl>();
        }
    
        public int Id { get; set; }
        public string Payment_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_tbl> Customer_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_invoice_tbl> Purchase_invoice_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_invoice_tbl> Sales_invoice_tbl { get; set; }
    }
}
