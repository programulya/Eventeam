using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Hotel.HotelCategory")]
    public partial class HotelCategory
    {
        public HotelCategory()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int HotelCategoryID { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
