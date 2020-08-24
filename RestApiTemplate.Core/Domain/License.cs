using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiTemplate.Core.Domain
{
    public class License
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LicenseId { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string LicenseName { get; set; }
    }
}