//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountPenaltyGMLog
    {
        public int AID { get; set; }
        public System.DateTime PEndDate { get; set; }
        public int PCode { get; set; }
        public int PLogID { get; set; }
        public byte Set_GM_TypeID { get; set; }
        public string Set_GM_ID { get; set; }
        public System.DateTime Set_Date { get; set; }
        public Nullable<byte> Reset_GM_TypeID { get; set; }
        public string Reset_GM_ID { get; set; }
        public Nullable<System.DateTime> Reset_Date { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual AccountPenaltyGMType AccountPenaltyGMType { get; set; }
        public virtual AccountPenaltyGMType AccountPenaltyGMType1 { get; set; }
    }
}
