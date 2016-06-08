using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Restaurant.RestaurantType")]
    public partial class RestaurantType
    {
        public RestaurantType()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        [Key]
        public int TypeId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
