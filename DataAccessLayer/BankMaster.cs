//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankMaster
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public Nullable<System.DateTime> Entered_On { get; set; }
        public Nullable<long> Entered_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<long> Modified_By { get; set; }
    }
}
