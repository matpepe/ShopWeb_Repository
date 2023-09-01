using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelWeb.Models
{
    public class Product
    {
        //[PrimaryKey()]
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }

        public string? ImageName { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("ProductId")]
        public List<ProductCategory>? ProductCategorise { get; set; }

        //[ForeignKey("ProductId")]
        //public List<OrderItem>? OrderItems { get; set; }

    }
}
