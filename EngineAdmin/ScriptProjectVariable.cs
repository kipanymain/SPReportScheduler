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
    
    public partial class ScriptProjectVariable
    {
        public int ScriptProjectVariableID { get; set; }
        public int ScriptProjectID { get; set; }
        public int ScriptVariableID { get; set; }
    
        public virtual ScriptProject ScriptProject { get; set; }
    }
}
