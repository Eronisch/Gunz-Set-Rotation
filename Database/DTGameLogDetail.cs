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
    
    public partial class DTGameLogDetail
    {
        public string TimeStamp { get; set; }
        public int LogID { get; set; }
        public System.DateTime StartTime { get; set; }
        public int PlayTime { get; set; }
        public byte MatchType { get; set; }
        public int WinnerCID { get; set; }
        public int LoserCID { get; set; }
        public int GainTP { get; set; }
        public int LoseTP { get; set; }
    
        public virtual DTGameLog DTGameLog { get; set; }
    }
}
