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
    
    public partial class Location
    {
        public Location()
        {
            this.Platforms = new HashSet<Platform>();
        }
    
        public int LocationID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Platform> Platforms { get; set; }
    }
}
