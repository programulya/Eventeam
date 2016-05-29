using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Restaurant.Restaurant")]
    public partial class Restaurant
    {
        public int RestaurantID { get; set; }
        public int PlatformID { get; set; }
        public int TypeID { get; set; }
        public int? ClassificationID { get; set; }
        public int KitchenID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        public int? Banquet { get; set; }
        public int? Buffet { get; set; }
        public int? TotalSquare { get; set; }
        public int? Seating { get; set; }

        public virtual Platform Platform { get; set; }
        public virtual Classification Classification { get; set; }
        public virtual Kitchen Kitchen { get; set; }
        public virtual RestaurantType RestaurantType { get; set; }
    }
}
