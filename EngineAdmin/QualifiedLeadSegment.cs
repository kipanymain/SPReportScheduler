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
    
    public partial class QualifiedLeadSegment
    {
        public long CONTACT_ID { get; set; }
        public int Campaign_ID { get; set; }
        public string ContactSegmentStatus { get; set; }
        public Nullable<int> ResponseStatusCode { get; set; }
        public string ResponseBody { get; set; }
        public Nullable<System.DateTime> ContactSent { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> Attempt { get; set; }
        public string RequestBody { get; set; }
    }
}