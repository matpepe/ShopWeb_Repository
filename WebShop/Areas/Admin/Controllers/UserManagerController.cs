using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelWeb.Administration;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserManagerController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<ApplicationUser> _userManager;

        public UserManagerController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            // dohvation sam preko usermanager sve korisnike u bazi podataka
            List<ApplicationUser> users = await _userManager.Users.ToListAsync();
            // pripremio listu view model-a za spremanje detalja korisnika
            List<UserRolesViewModel> userRolesViewModel = new List<UserRolesViewModel>();

            // iteriram po dohvaćenim korisnicima i spremam ih u bazu podataka
            foreach (ApplicationUser user in users)
            {
                UserRolesViewModel viewModel = new UserRolesViewModel();
                viewModel.UserId = user.Id;
                viewModel.Email = user.Email;
                viewModel.UserName = user.UserName;
                viewModel.FirstName = user.FirstName;
                viewModel.LastName = user.LastName;
                viewModel.Roles = await GetUserRoles(user);

                userRolesViewModel.Add(viewModel);
            }

            return View(userRolesViewModel);
        }

        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            return roles.ToList();
        }

        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.UserId = userId;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            ViewBag.UserName = user.UserName;
            // dohvati sve uloge za korisnika i spremi ih u 
            // pripremljeni view model ManageUserRolesViewModel
            var vm = new List<ManageUserRolesViewModel>();

            foreach (var role in _roleManager.Roles)
            {
                ManageUserRolesViewModel model = new ManageUserRolesViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Selected = true;
                }
                else
                {
                    model.Selected = false;
                }

                vm.Add(model);
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Manage(List<ManageUserRolesViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                //return NotFound;
                return View(model);
            }

            var selectedRoles = model.Where(r => r.Selected == true).Select(r => r.RoleName).ToList();

            result = await _userManager.AddToRolesAsync(user, selectedRoles);

            if (!result.Succeeded)
            {
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        //----------------------
        //[HttpGet]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);
        //    if (user == null) return NotFound();

        //    return View(user);
        //}

        [HttpPost]
        //[ActionName("Delete")]
        public async Task<IActionResult> Delete(string Id)
        {
            if (Id == "")
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(Id);

            if (user == null)
            {
                return NotFound();
            }

            _userManager.DeleteAsync(user);

            //_userManager.AddClaimAsync(user);
            //_userManager.Users.Remove(user);
            //_userManager.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        // List<ApplicationUser> users = await _userManager.Users.ToListAsync();
        // Delete metode 
    }
}
