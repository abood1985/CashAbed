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
    
    public partial class Acc_d
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acc_d()
        {
            this.Installment_tbl = new HashSet<Installment_tbl>();
            this.Purchase_invoice_tbl = new HashSet<Purchase_invoice_tbl>();
            this.Sales_invoice_tbl = new HashSet<Sales_invoice_tbl>();
            this.Sales_Receipt_payment_tbl = new HashSet<Sales_Receipt_payment_tbl>();
        }
    
        public int Id { get; set; }
        public string Acc_d_name { get; set; }
        public Nullable<int> Acc_d_belong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Installment_tbl> Installment_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_invoice_tbl> Purchase_invoice_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_invoice_tbl> Sales_invoice_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Receipt_payment_tbl> Sales_Receipt_payment_tbl { get; set; }
    }
}
