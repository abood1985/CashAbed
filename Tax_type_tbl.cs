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
    
    public partial class Tax_type_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tax_type_tbl()
        {
            this.Item_kind_tbl = new HashSet<Item_kind_tbl>();
        }
    
        public int Id { get; set; }
        public string Tax_name { get; set; }
        public Nullable<double> Tax_percent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_kind_tbl> Item_kind_tbl { get; set; }
    }
}
