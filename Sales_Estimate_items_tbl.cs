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
    
    public partial class Sales_Estimate_items_tbl
    {
        public int Id { get; set; }
        public Nullable<int> Sales_Estimate_id { get; set; }
        public Nullable<int> Item_id { get; set; }
        public string Description { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<int> Unit_id { get; set; }
        public Nullable<double> Item_price { get; set; }
        public Nullable<int> Store_id { get; set; }
        public string Item_tax { get; set; }
        public string Item_tax_type { get; set; }
        public Nullable<double> Item_tax_percent { get; set; }
        public Nullable<double> Item_tax_amount { get; set; }
        public string Descount_type { get; set; }
        public Nullable<double> Descount_percent { get; set; }
        public Nullable<double> Discount_amount_item { get; set; }
        public Nullable<double> Amount_after_tax { get; set; }
        public Nullable<double> Amount_before_tax { get; set; }
    
        public virtual Items_tbl Items_tbl { get; set; }
        public virtual Sales_Estimate_tbl Sales_Estimate_tbl { get; set; }
        public virtual Store_tbl Store_tbl { get; set; }
        public virtual Unit_tbl Unit_tbl { get; set; }
    }
}
