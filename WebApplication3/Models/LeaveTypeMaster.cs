//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveTypeMaster
    {
        public int Id { get; set; }
        public string cLeaveTypeCode { get; set; }
        public string cLeaveTypeDesc { get; set; }
        public string cPaid { get; set; }
        public string cCarry { get; set; }
        public string cCredit { get; set; }
        public string cCategory { get; set; }
        public Nullable<int> nOrder { get; set; }
    }
}