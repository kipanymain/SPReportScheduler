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
    
    public partial class ScriptLookupDetail
    {
        public int ScriptLookupDetailID { get; set; }
        public int ScriptLookupID { get; set; }
        public string LookupText { get; set; }
        public string LookupValue { get; set; }
    
        public virtual ScriptLookup ScriptLookup { get; set; }
    }
}
