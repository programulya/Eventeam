//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eventeam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hall
    {
        public int HallID { get; set; }
        public int PlatformID { get; set; }
        public string Name { get; set; }
        public Nullable<int> TotalSquare { get; set; }
        public Nullable<int> Theater { get; set; }
        public Nullable<int> Class { get; set; }
        public Nullable<int> PPlanting { get; set; }
        public Nullable<int> MeetingRoom { get; set; }
        public Nullable<int> Banquet { get; set; }
        public Nullable<int> Buffet { get; set; }
        public string Equipment { get; set; }
        public string ShortName { get; set; }
    
        public virtual Platform Platform { get; set; }
    }
}
