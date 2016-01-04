using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventeam.Models
{
    public class HotelViewModel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public int HotelCategoryName { get; set; }
        public string HotelSite { get; set; }
        public int RoomCount { get; set; }
        public int Capacity { get; set; }
        public string Entertainment { get; set; }
        public string Rehabilitation { get; set; }
        public string Parking { get; set; }
        public string Internet { get; set; }
        public string Other { get; set; }
        public IList<ImageViewModel> HotelPhotos { get; set; }

    }
}