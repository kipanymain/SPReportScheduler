//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EngineAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class FBImpression
    {
        public int ID { get; set; }
        public long FBAccountID { get; set; }
        public long FBAdID { get; set; }
        public Nullable<int> FBAdsetID { get; set; }
        public Nullable<int> FBCampignId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string FBAdName { get; set; }
        public Nullable<int> Impressions { get; set; }
        public Nullable<int> Clicks { get; set; }
        public Nullable<int> UniqueClicks { get; set; }
        public Nullable<int> Visits { get; set; }
        public Nullable<int> Frequency { get; set; }
        public Nullable<decimal> AmountSpent { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> AllLeads { get; set; }
        public Nullable<int> UniqueLeads { get; set; }
    }
}
