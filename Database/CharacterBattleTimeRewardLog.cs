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
    
    public partial class CharacterBattleTimeRewardLog
    {
        public int CID { get; set; }
        public int BRID { get; set; }
        public int BRTID { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public int BattleTime { get; set; }
        public int KillCount { get; set; }
        public int ItemID { get; set; }
        public int ItemCnt { get; set; }
        public int RentHourPeriod { get; set; }
    }
}
