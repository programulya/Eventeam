using System;
using System.Collections.Generic;

namespace Eventeam.Models
{
    public class HotelViewModel
    {
        public int HotelID { get; set; }
        public int PlatformID { get; set; }
        public int? HotelCategoryName { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public int RoomCount { get; set; }
        public int Capacity { get; set; }
        public string Entertainment { get; set; }
        public string Rehabilitation { get; set; }
        public string Parking { get; set; }
        public string Internet { get; set; }
        public string Other { get; set; }
        public string FolderName { get; set; }

        public ImageViewModel MainPhoto { get; set; }
        public IList<ImageViewModel> PlatformPhotos { get; set; }
    }
}