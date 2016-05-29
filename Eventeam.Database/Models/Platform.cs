using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Eventeam.Database.Models
{
    [Table("Platform")]
    public partial class Platform
    {
        public Platform()
        {
            Halls = new HashSet<Hall>();
            Hotels = new HashSet<Hotel>();
            Restaurants = new HashSet<Restaurant>();
        }

        public int PlatformID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        public int CityID { get; set; }
        public int LevelID { get; set; }
        public int LocationID { get; set; }

        [Required]
        public DbGeography Geography { get; set; }

        [Required]
        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Subway { get; set; }

        public double? DistanceRailwayStation { get; set; }
        public double? DistanceAirportBorispil { get; set; }
        public double? DistanceAirportZhulyany { get; set; }

        [StringLength(500)]
        public string Site { get; set; }

        public int? HallsCount { get; set; }
        public int? HallCapacity { get; set; }
        public int? RestaurantsCount { get; set; }
        public int? BanquetCapacity { get; set; }
        public int? BuffetCapacity { get; set; }

        public virtual City City { get; set; }
        public virtual Level Level { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
