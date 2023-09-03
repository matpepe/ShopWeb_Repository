using Microsoft.AspNetCore.Http;
using ModelWeb.Administration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)"), Range(1, 2000000)]
        public decimal Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)"), Range(1, 2000000)]
        public decimal Price { get; set; } = 0;

        public string? ImageName { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [ForeignKey("ProductId")]
        public List<ProductCategory>? ProductCategorise { get; set; }

        public DateTime? CreatedDatetime { get; set; } = DateTime.Now;

        [ForeignKey("UserId")]
        public ApplicationUser? ApplicationUser { get; set; }

        [Required, NotMapped]
        public bool Active { get; set; } = true;

    }
}
