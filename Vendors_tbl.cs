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
    
    public partial class Vendors_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendors_tbl()
        {
            this.Purchase_order_tbl = new HashSet<Purchase_order_tbl>();
        }
    
        public int Id { get; set; }
        public string Vendor_display_name { get; set; }
        public string Vendor_tax_num { get; set; }
        public string Vendor_activ { get; set; }
        public string Vendor_first_name { get; set; }
        public string Vendor_last_name { get; set; }
        public string Vendo_Email { get; set; }
        public string Vendo_Phone { get; set; }
        public string Vendo_Mobile { get; set; }
        public string Vender_payment_terms { get; set; }
        public Nullable<int> Currency_id { get; set; }
        public string Vendo_Notes { get; set; }
        public string Vendo_Website { get; set; }
        public Nullable<int> Country_id { get; set; }
        public Nullable<int> City_id { get; set; }
        public Nullable<int> Town_id { get; set; }
        public string Street_name { get; set; }
        public string Fax { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public Nullable<double> Opining_balance { get; set; }
        public string Payment_preferred { get; set; }
    
        public virtual City_tbl City_tbl { get; set; }
        public virtual Country_tbl Country_tbl { get; set; }
        public virtual Currency_tbl Currency_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_order_tbl> Purchase_order_tbl { get; set; }
        public virtual Town_tbl Town_tbl { get; set; }
    }
}
