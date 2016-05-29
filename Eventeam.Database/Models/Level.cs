using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Level")]
    public partial class Level
    {
        public Level()
        {
            Platforms = new HashSet<Platform>();
        }

        public int LevelID { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Platform> Platforms { get; set; }
    }
}
