using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Location")]
    public partial class Location
    {
        public Location()
        {
            Platforms = new HashSet<Platform>();
        }

        public int LocationID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Platform> Platforms { get; set; }
    }
}
