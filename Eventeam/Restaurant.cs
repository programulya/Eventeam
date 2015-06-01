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
    
    public partial class Restaurant
    {
        public int RestaurantID { get; set; }
        public int PlatformID { get; set; }
        public Nullable<int> ClassificationID { get; set; }
        public int KitchenID { get; set; }
        public string Name { get; set; }
        public string FolderName { get; set; }
        public Nullable<int> Banquet { get; set; }
        public Nullable<int> Buffet { get; set; }
        public Nullable<int> TotalSquare { get; set; }
        public Nullable<int> Seating { get; set; }
    
        public virtual Classification Classification { get; set; }
        public virtual Kitchen Kitchen { get; set; }
        public virtual Platform Platform { get; set; }
    }
}
