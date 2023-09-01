using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ModelWeb.Administration
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [StringLength(150)]
        public string? Address { get; set; }
        public int? UsernameChangeLimit { get; set; } = 10;
        public byte[]? ProfilePicture { get; set; }



        //[ForeignKey("UserId")]
        //public List<Order> Orders { get; set; }
    }
}
