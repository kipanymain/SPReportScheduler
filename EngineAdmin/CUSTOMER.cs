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
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.Locations = new HashSet<Location>();
        }
    
        public string CUST_ID { get; set; }
        public string CUST_NUMBER { get; set; }
        public string BOTH { get; set; }
        public string NAME { get; set; }
        public string ADDRESS_ONE { get; set; }
        public string ADDRESS_TWO { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string PHONE { get; set; }
        public string ZIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
    }
}
