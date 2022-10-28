using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API3Assignment.Entities
{
    [Table("Order")]
    public class Order
    {
            [Key]
            public int OrderId { get; set; }

            public DateTime? OrderDate { get; set; }
            [ForeignKey("Product")]
            public int ProductId { get; set; }
    }
}
