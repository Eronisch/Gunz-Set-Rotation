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
    
    public partial class ClanMember
    {
        public int CMID { get; set; }
        public Nullable<int> CLID { get; set; }
        public Nullable<int> CID { get; set; }
        public byte Grade { get; set; }
        public System.DateTime RegDate { get; set; }
        public int ContPoint { get; set; }
    
        public virtual Character Character { get; set; }
        public virtual Clan Clan { get; set; }
    }
}
