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
    
    public partial class ScriptClientEnvironment
    {
        public int ScriptClientEnvironmentId { get; set; }
        public string ScriptClientID { get; set; }
        public string Name { get; set; }
        public string DBServer { get; set; }
        public string DBName { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual ScriptClient ScriptClient { get; set; }
    }
}
