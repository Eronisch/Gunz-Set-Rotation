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
    
    public partial class QuestItem
    {
        public int QIID { get; set; }
        public string Name { get; set; }
        public Nullable<byte> Level { get; set; }
        public string Description { get; set; }
        public Nullable<int> Price { get; set; }
        public bool UniqueItem { get; set; }
        public bool Sacrifice { get; set; }
        public string Type { get; set; }
        public Nullable<int> Param { get; set; }
    }
}
