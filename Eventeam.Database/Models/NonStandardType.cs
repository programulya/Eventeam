using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("NonStandard.NonStandardType")]
    public partial class NonStandardType
    {
        [Key]
        public int TypeID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
