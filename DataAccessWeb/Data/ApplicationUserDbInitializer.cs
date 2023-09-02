using Microsoft.AspNetCore.Identity;
using ModelWeb.Administration;

namespace DataAccessWeb.Data
{
    public static class ApplicationUserDbInitializer
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser userAdmin = new ApplicationUser()
            {
                UserName = "Admin@gmail.uk",
                Email = "Admin@gmail.uk"
            };

            ApplicationUser normalUser = new ApplicationUser()
            {
                UserName = "User@gmail.uk",
                Email = "User@gmail.uk"
            };

            ApplicationUser normalUser2 = new ApplicationUser()
            {
                UserName = "User2@gmail.uk",
                Email = "User2@gmail.uk"
            };

            var result1 = userManager.CreateAsync(userAdmin, "password").Result;
            var result2 = userManager.CreateAsync(normalUser, "password").Result;
            var result3 = userManager.CreateAsync(normalUser2, "password").Result;


            if (result1.Succeeded && result2.Succeeded && result3.Succeeded)
            {
                userManager.AddToRoleAsync(userAdmin, "Admin").Wait();
                userManager.AddToRoleAsync(normalUser, "User").Wait();
                userManager.AddToRoleAsync(normalUser2, "User").Wait();

            }
        }
    }
}
