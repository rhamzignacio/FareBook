//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FareBook.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientProfile
    {
        public System.Guid ID { get; set; }
        public string ClientCode { get; set; }
        public string ClientType { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string Biller { get; set; }
        public string AccountOfficer { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> BillerID { get; set; }
        public Nullable<System.DateTime> ContractStartDate { get; set; }
        public Nullable<System.DateTime> ContractEndDate { get; set; }
    }
}
