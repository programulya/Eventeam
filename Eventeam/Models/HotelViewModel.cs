using System.Collections.Generic;

namespace Eventeam.Models
{
    public class HotelViewModel
    {
        public int HotelId { get; set; }
        public int HotelCategoryName { get; set; }
        public string HotelName { get; set; }
        public string HotelSite { get; set; }
        public int RoomCount { get; set; }
        public int Capacity { get; set; }
        public string Entertainment { get; set; }
        public string Rehabilitation { get; set; }
        public string Parking { get; set; }
        public string Internet { get; set; }
        public string Other { get; set; }

        public string PlatformName { get; set; }
        public string PlatformCityName { get; set; }
        public int PlatformLevelName { get; set; }
        public string PlatformLocationName { get; set; }
        public System.Data.Entity.Spatial.DbGeography PlatformGeography { get; set; }
        public string PlatformAddress { get; set; }
        public string PlatformSite { get; set; }

        public ImageViewModel MainPhoto { get; set; }
        public IList<ImageViewModel> PlatformPhotos { get; set; }
    }
}