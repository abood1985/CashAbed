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
    
    public partial class Ownership_kind_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ownership_kind_tbl()
        {
            this.Company_tbl = new HashSet<Company_tbl>();
        }
    
        public int Id { get; set; }
        public string Ownership_name { get; set; }
        public Nullable<double> Ownership_tax_add { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_tbl> Company_tbl { get; set; }
    }
}