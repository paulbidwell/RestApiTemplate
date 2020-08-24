using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiTemplate.Core.Domain
{
    public class Collection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollectionId { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string CollectionName { get; set; }
        public ICollection<CollectionFunkoPop> CollectionFunkoPops { get; set; }
    }
}