//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AyatDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.ActivityLogs = new HashSet<ActivityLog>();
            this.Sales = new HashSet<Sale>();
        }
    
        public int ID { get; set; }
        public string type { get; set; }
        public string deviceName { get; set; }
        public bool isActive { get; set; }
        public string IP { get; set; }
        public string connectionType { get; set; }
        public string value { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string MAC { get; set; }
        public string port { get; set; }
        public string remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
