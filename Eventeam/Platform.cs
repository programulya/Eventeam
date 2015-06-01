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
    
    public partial class Platform
    {
        public Platform()
        {
            this.Halls = new HashSet<Hall>();
            this.Hotels = new HashSet<Hotel>();
            this.Restaurants = new HashSet<Restaurant>();
        }
    
        public int PlatformID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
        public int LevelID { get; set; }
        public int LocationID { get; set; }
        public System.Data.Entity.Spatial.DbGeography Geography { get; set; }
        public string Address { get; set; }
        public string Site { get; set; }
    
        public virtual City City { get; set; }
        public virtual Level Level { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Hall> Halls { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
