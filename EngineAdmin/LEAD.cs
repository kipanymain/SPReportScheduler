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
    
    public partial class LEAD
    {
        public int LEAD_ID { get; set; }
        public string URL_ID { get; set; }
        public Nullable<int> AD_ID { get; set; }
        public string GENDER { get; set; }
        public Nullable<System.DateTime> DATEOFBIRTH { get; set; }
        public string EMAIL { get; set; }
        public string PHONENUMBER { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string ADDRESS { get; set; }
        public string POSTALCODE { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string IP { get; set; }
        public string URLREFERER { get; set; }
        public string TRUSTED_FORM_URL { get; set; }
        public Nullable<System.DateTime> CREATEDAT { get; set; }
        public Nullable<bool> QUALIFIED { get; set; }
        public Nullable<bool> UNIQUELEAD { get; set; }
    
        public virtual ContactRecord ContactRecord { get; set; }
    }
}