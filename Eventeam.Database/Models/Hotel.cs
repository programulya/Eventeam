using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Hotel.Hotel")]
    public partial class Hotel
    {
        public Hotel()
        {
            Rooms = new HashSet<Room>();
        }

        public int HotelID { get; set; }
        public int PlatformID { get; set; }
        public int? HotelCategoryID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        [StringLength(200)]
        public string Site { get; set; }

        public int? RoomCount { get; set; }
        public int? Capacity { get; set; }
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
