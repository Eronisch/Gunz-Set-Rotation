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
    
    public partial class SurvivalGameLog
    {
        public System.DateTime StartTime { get; set; }
        public System.DateTime FinishTime { get; set; }
        public int Master_Player { get; set; }
        public int GainRP1 { get; set; }
        public Nullable<int> Player2 { get; set; }
        public Nullable<int> GainRP2 { get; set; }
        public Nullable<int> Player3 { get; set; }
        public Nullable<int> GainRP3 { get; set; }
        public Nullable<int> Player4 { get; set; }
        public Nullable<int> GainRP4 { get; set; }
        public string GameName { get; set; }
        public byte SID { get; set; }
        public short TotalRound { get; set; }
    
        public virtual SurvivalScenarioID SurvivalScenarioID { get; set; }
    }
}
