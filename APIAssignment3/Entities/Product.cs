using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace API3Assignment.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(20)]
        [Column(TypeName = "varchar")]
        [Required]
        public string PName { get; set; }
        public string? Description { get; set; }
        public int price { get; set; }
    }
}
