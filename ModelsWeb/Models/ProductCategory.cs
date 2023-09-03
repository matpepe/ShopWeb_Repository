using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelWeb.Models
{
    public class ProductCategory
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ProductId { get; set; } = 5; //unknown 

        [NotMapped]
        public string? ProductTitle { get; set; }
        [NotMapped]
        public string? CategoryTitle { get; set; }
    }
}
