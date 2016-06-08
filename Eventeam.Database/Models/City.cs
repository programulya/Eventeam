using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("City")]
    public partial class City
    {
        public City()
        {
            Platforms = new HashSet<Platform>();
        }

        public int CityID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Platform> Platforms { get; set; }
    }
}
