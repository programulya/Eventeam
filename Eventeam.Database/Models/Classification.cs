using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Restaurant.Classification")]
    public partial class Classification
    {
        public Classification()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        public int ClassificationID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
