using System.ComponentModel.DataAnnotations.Schema;

namespace ModelWeb.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        [NotMapped]
        public string? ProductTitle { get; set; }
        [NotMapped]
        public string? CategoryTitle { get; set; }
    }
}
