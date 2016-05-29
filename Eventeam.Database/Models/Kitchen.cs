using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Restaurant.Kitchen")]
    public partial class Kitchen
    {
        public Kitchen()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        public int KitchenID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
