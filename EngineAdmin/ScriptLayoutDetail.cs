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
    
    public partial class ScriptLayoutDetail
    {
        public int ScriptLayoutDetailID { get; set; }
        public int ScriptLayoutID { get; set; }
        public int RowNumber { get; set; }
        public int Sequence { get; set; }
        public int ElementID { get; set; }
        public string ElementType { get; set; }
        public string ElementWidth { get; set; }
        public string ElementAlignment { get; set; }
    
        public virtual ScriptLayout ScriptLayout { get; set; }
    }
}