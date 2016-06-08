using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Hotel.Room")]
    public partial class Room
    {
        public int RoomID { get; set; }
        public int HotelID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int RoomCategoryID { get; set; }
        public int RoomTypeID { get; set; }
        public int Quantity { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual RoomCategory RoomCategory { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
