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
    
    public partial class spGetPaymentPlanByid_Result
    {
        public int ID { get; set; }
        public int salesID { get; set; }
        public string description { get; set; }
        public decimal payRate { get; set; }
        public decimal payAmount { get; set; }
        public decimal paidAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public int payStatus { get; set; }
        public decimal commRate { get; set; }
        public decimal commAmount { get; set; }
        public string remark { get; set; }
    }
}
