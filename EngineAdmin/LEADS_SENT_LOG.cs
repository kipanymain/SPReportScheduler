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
    
    public partial class LEADS_SENT_LOG
    {
        public long LEAD_SENT_LOG_ID { get; set; }
        public string STATUS { get; set; }
        public Nullable<int> CAMPAIGN_ID { get; set; }
        public Nullable<int> CLIENT_ID { get; set; }
        public string URLCONNECTION { get; set; }
        public Nullable<System.DateTime> LAST_LEAD_SEND { get; set; }
        public string DATA_SENT { get; set; }
    }
}
