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
    
    public partial class spGetCommissionPaymentsAndDetails_Result
    {
        public int ID { get; set; }
        public System.DateTime IssuedDate { get; set; }
        public System.DateTime PreparedDate { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public decimal Amount { get; set; }
        public string BankPaymentNo { get; set; }
        public Nullable<System.DateTime> BankPaymentDate { get; set; }
        public string commissionRole { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string fullName { get; set; }
        public Nullable<decimal> employeeCommission { get; set; }
        public string PreparingUser { get; set; }
        public string PreparingDevice { get; set; }
        public string ApprovingUser { get; set; }
        public string ApprovingDevice { get; set; }
    }
}