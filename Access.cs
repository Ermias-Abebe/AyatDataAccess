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
    
    public partial class Access
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public int accessPrivilage { get; set; }
        public string remark { get; set; }
    
        public virtual UserName UserName { get; set; }
    }
}
