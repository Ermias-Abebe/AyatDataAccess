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
    
    public partial class spGetEmployeeCommissionSummary_Result
    {
        public int ID { get; set; }
        public string fullName { get; set; }
        public string code { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string FAName { get; set; }
        public Nullable<decimal> unavailableCom { get; set; }
        public Nullable<decimal> availableCom { get; set; }
        public Nullable<decimal> paidCom { get; set; }
        public Nullable<decimal> pendingCom { get; set; }
        public Nullable<decimal> totalCom { get; set; }
        public Nullable<decimal> paidPercent { get; set; }
    }
}