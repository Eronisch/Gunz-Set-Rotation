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
    
    public partial class CharacterComment
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public int AccountId { get; set; }
        public string Comment { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Character Character { get; set; }
    }
}
