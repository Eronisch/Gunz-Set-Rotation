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
    
    public partial class Friend
    {
        public int id { get; set; }
        public int CID { get; set; }
        public int FriendCID { get; set; }
        public int Type { get; set; }
        public Nullable<byte> Favorite { get; set; }
        public Nullable<byte> DeleteFlag { get; set; }
    
        public virtual Character Character { get; set; }
        public virtual Character Character1 { get; set; }
    }
}
