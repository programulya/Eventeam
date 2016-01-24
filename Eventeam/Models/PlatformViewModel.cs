using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace Eventeam.Models
{
    public class PlatformViewModel
    {
        // Platform
        public int PlatformId { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public int LevelName { get; set; }
        public string LocationName { get; set; }
        public DbGeography Geography { get; set; }
        public string Address { get; set; }
        public string Subway { get; set; }
        public double? DistanceRailwayStation { get; set; }
        public double? DistanceAirportBorispil { get; set; }
        public double? DistanceAirportZhulyany { get; set; }
        public string Site { get; set; }
        public int? HallsCount { get; set; }
        public int? HallCapacity { get; set; }
        public int? RestaurantsCount { get; set; }
        public int? BanquetCapacity { get; set; }
        public int? BuffetCapacity { get; set; }

        public ImageViewModel MainPhoto { get; set; }
        public IList<ImageViewModel> PlatformPhotos { get; set; }

        // Hotel
        public HotelViewModel Hotel { get; set; }

        // Restaurants
        public IList<RestaurantViewModel> Restaurants { get; set; }

        // Halls
        public IList<HallViewModel> Halls { get; set; }
    }
}