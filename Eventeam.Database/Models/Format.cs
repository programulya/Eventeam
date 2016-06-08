using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Portfolio.Format")]
    public partial class Format
    {
        public Format()
        {
            Portfolios = new HashSet<Portfolio>();
        }

        public int FormatID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}
