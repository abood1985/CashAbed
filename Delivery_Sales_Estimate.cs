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
    
    public partial class Delivery_Sales_Estimate
    {
        public int Id { get; set; }
        public Nullable<int> Sales_Estimate_id { get; set; }
        public Nullable<System.DateTime> Delivery_date { get; set; }
        public Nullable<System.DateTime> Expiry_date { get; set; }
        public string Sales_Estimate_status { get; set; }
        public string Sails_person { get; set; }
        public string Delivery_note { get; set; }
        public string Delivery_tirms_conditions { get; set; }
        public string Delivery_recipient { get; set; }
    
        public virtual Sales_Estimate_tbl Sales_Estimate_tbl { get; set; }
    }
}
