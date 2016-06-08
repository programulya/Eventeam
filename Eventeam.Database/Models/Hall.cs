using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Hall.Hall")]
    public partial class Hall
    {
        public int HallID { get; set; }
        public int PlatformID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        public int? TotalSquare { get; set; }
        public int? Theater { get; set; }
        public int? Class { get; set; }
        public int? PPlanting { get; set; }
        public int? MeetingRoom { get; set; }
        public int? Banquet { get; set; }
        public int? Buffet { get; set; }
        public string Equipment { get; set; }

        public virtual Platform Platform { get; set; }
    }
}
