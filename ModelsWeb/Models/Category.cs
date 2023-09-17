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
        [Required, NotMapped]
        public bool Active { get; set; } = true;

        [ForeignKey("CategoryId")]
        public List<ProductCategory>? ProductCategories { get; set; }

        [ForeignKey("UserId")]
        public string? ApplicationUser { get; set; }
        //public DateTime? CreatedDatetime { get; set; } = DateTime.Now;

    }
}
