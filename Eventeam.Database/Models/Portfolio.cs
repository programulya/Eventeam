using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventeam.Database.Models
{
    [Table("Portfolio.Portfolio")]
    public partial class Portfolio
    {
        public int PortfolioID { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        [Required]
        [StringLength(200)]
        public string ProjectName { get; set; }

        public int FormatID { get; set; }

        [Required]
        [StringLength(200)]
        public string Сustomer { get; set; }

        [Required]
        [StringLength(200)]
        public string Participants { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; }

        [Required]
        public string Task { get; set; }

        [Required]
        public string Implementation { get; set; }

        [Required]
        public string Result { get; set; }

        public virtual Format Format { get; set; }
    }
}
