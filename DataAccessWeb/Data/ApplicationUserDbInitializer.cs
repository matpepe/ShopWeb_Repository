using Microsoft.AspNetCore.Identity;
using ModelWeb.Administration;

namespace DataAccessWeb.Data
{
    public static class ApplicationUserDbInitializer
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser user = new ApplicationUser()
            {
                UserName = "Admin@gmail.uk",
                Email = "Admin@gmail.uk"
            };

            var result = userManager.CreateAsync(user, "password").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user, "Admin").Wait();
            }
        }
    }
}
