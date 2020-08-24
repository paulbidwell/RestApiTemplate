using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiTemplate.Core.Domain
{
    public class FunkoPop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FunkoPopId { get; set; }
        public int MoldNumber { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        public string Name { get; set; }
        public int Year { get; set; }
        public Category Category { get; set; }
        public Feature Feature { get; set; }
        public License License { get; set; }
        public ICollection<CollectionFunkoPop> CollectionFunkoPops { get; set; }
    }
}