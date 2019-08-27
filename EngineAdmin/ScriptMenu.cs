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
    
    public partial class ScriptMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScriptMenu()
        {
            this.ScriptDashes = new HashSet<ScriptDash>();
            this.ScriptProjects = new HashSet<ScriptProject>();
        }
    
        public int ScriptMenuID { get; set; }
        public string MenuDesc { get; set; }
        public string MenuXML { get; set; }
        public string MenuOrientation { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateLastModified { get; set; }
        public string UserLastModified { get; set; }
        public string ClientID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScriptDash> ScriptDashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScriptProject> ScriptProjects { get; set; }
    }
}