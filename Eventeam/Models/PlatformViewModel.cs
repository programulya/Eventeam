using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventeam.Models
{
    public class PlatformViewModel
    {
        // Platform
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public string PlatformCityName { get; set; }
        public int PlatformLevelName { get; set; }
        public string PlatformLocationName { get; set; }
        public System.Data.Entity.Spatial.DbGeography PlatformGeography { get; set; }
        public string PlatformAddress { get; set; }
        public string PlatformSite { get; set; }

        public ImageViewModel MainPhoto { get; set; }
        public IList<ImageViewModel> PlatformPhotos { get; set; }

        // Hotels
        public IList<HotelViewModelNew> Hotels { get; set; }


        // Restaurants
    }
}