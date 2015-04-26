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
    
    public partial class Hotel
    {
        public Hotel()
        {
            this.Rooms = new HashSet<Room>();
        }
    
        public int HotelID { get; set; }
        public int PlatformID { get; set; }
        public Nullable<int> HotelCategoryID { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public int RoomCount { get; set; }
        public int Capacity { get; set; }
        public string Entertainment { get; set; }
        public string Rehabilitation { get; set; }
        public string Parking { get; set; }
        public string Internet { get; set; }
        public string Other { get; set; }
    
        public virtual Platform Platform { get; set; }
        public virtual HotelCategory HotelCategory { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
