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
    
    public partial class Payment
    {
        public int ID { get; set; }
        public int salesID { get; set; }
        public int payID { get; set; }
        public string recieptNo { get; set; }
        public System.DateTime date { get; set; }
        public decimal amount { get; set; }
        public string remark { get; set; }
        public string FsNo { get; set; }
    
        public virtual PaymentPlan PaymentPlan { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
