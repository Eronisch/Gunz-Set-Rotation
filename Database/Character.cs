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
    
    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            this.BringAccountItemLogs = new HashSet<BringAccountItemLog>();
            this.CharacterItems = new HashSet<CharacterItem>();
            this.Friends = new HashSet<Friend>();
            this.Friends1 = new HashSet<Friend>();
            this.ItemPurchaseLogByBounties = new HashSet<ItemPurchaseLogByBounty>();
            this.Clans = new HashSet<Clan>();
            this.ClanMembers = new HashSet<ClanMember>();
            this.CharacterMgrLogByGMs = new HashSet<CharacterMgrLogByGM>();
            this.CharacterComments = new HashSet<CharacterComment>();
            this.CharacterSkills = new HashSet<CharacterSkill>();
            this.EventCharacters = new HashSet<EventCharacter>();
        }
    
        public int CID { get; set; }
        public int AID { get; set; }
        public string Name { get; set; }
        public short Level { get; set; }
        public byte Sex { get; set; }
        public short CharNum { get; set; }
        public Nullable<byte> Hair { get; set; }
        public Nullable<byte> Face { get; set; }
        public int XP { get; set; }
        public int BP { get; set; }
        public Nullable<short> HP { get; set; }
        public Nullable<short> AP { get; set; }
        public Nullable<int> FR { get; set; }
        public Nullable<int> CR { get; set; }
        public Nullable<int> ER { get; set; }
        public Nullable<int> WR { get; set; }
        public Nullable<int> head_slot { get; set; }
        public Nullable<int> chest_slot { get; set; }
        public Nullable<int> hands_slot { get; set; }
        public Nullable<int> legs_slot { get; set; }
        public Nullable<int> feet_slot { get; set; }
        public Nullable<int> fingerl_slot { get; set; }
        public Nullable<int> fingerr_slot { get; set; }
        public Nullable<int> melee_slot { get; set; }
        public Nullable<int> primary_slot { get; set; }
        public Nullable<int> secondary_slot { get; set; }
        public Nullable<int> custom1_slot { get; set; }
        public Nullable<int> custom2_slot { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<System.DateTime> LastTime { get; set; }
        public Nullable<int> PlayTime { get; set; }
        public Nullable<int> GameCount { get; set; }
        public Nullable<int> KillCount { get; set; }
        public Nullable<int> DeathCount { get; set; }
        public Nullable<byte> DeleteFlag { get; set; }
        public string DeleteName { get; set; }
        public Nullable<int> head_itemid { get; set; }
        public Nullable<int> chest_itemid { get; set; }
        public Nullable<int> hands_itemid { get; set; }
        public Nullable<int> legs_itemid { get; set; }
        public Nullable<int> feet_itemid { get; set; }
        public Nullable<int> fingerl_itemid { get; set; }
        public Nullable<int> fingerr_itemid { get; set; }
        public Nullable<int> melee_itemid { get; set; }
        public Nullable<int> primary_itemid { get; set; }
        public Nullable<int> secondary_itemid { get; set; }
        public Nullable<int> custom1_itemid { get; set; }
        public Nullable<int> custom2_itemid { get; set; }
        public byte[] QuestItemInfo { get; set; }
        public Nullable<int> nRedColor { get; set; }
        public Nullable<int> nGreenColor { get; set; }
        public Nullable<int> nBlueColor { get; set; }
        public Nullable<int> BPPlus { get; set; }
        public string HeaderUrl { get; set; }
        public string AvatarUrl { get; set; }
        public string About { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BringAccountItemLog> BringAccountItemLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacterItem> CharacterItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Friend> Friends { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Friend> Friends1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPurchaseLogByBounty> ItemPurchaseLogByBounties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clan> Clans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClanMember> ClanMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacterMgrLogByGM> CharacterMgrLogByGMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacterComment> CharacterComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacterSkill> CharacterSkills { get; set; }
        public virtual Event_Coliseum_Character_NHN Event_Coliseum_Character_NHN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventCharacter> EventCharacters { get; set; }
    }
}
