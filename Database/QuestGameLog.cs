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
    
    public partial class QuestGameLog
    {
        public int id { get; set; }
        public string GameName { get; set; }
        public int Master { get; set; }
        public Nullable<int> Player1 { get; set; }
        public Nullable<int> Player2 { get; set; }
        public Nullable<int> Player3 { get; set; }
        public Nullable<byte> TotalQItemCount { get; set; }
        public short ScenarioID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    }
}
