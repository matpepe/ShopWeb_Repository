using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        [ForeignKey("CategoryId")]
        public List<ProductCategory>? ProductCategories { get; set; }
    }
}
