using DataAccessWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoleManagerController : Controller
    {
        private ApplicationDbContext _dbContext;
        private RoleManager<IdentityRole> _roleManager;

        public RoleManagerController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(_roleManager.Roles.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = roleName,
                };

                await _roleManager.CreateAsync(role);
            }

            return RedirectToAction(nameof(Index));
        }

        //-----------------------
        [HttpPost]
        //[ActionName("Delete")]
        // HTTP POST /Category/DeleteConfirmed
        public async Task<IActionResult> Delete(string? Id)
        {
            if (Id == "" || Id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(Id);

            if (role == null)
            {
                return NotFound();
            }

            _roleManager.DeleteAsync(role);


            //_dbContext.Roles.Remove(role);
            //_userManager.AddClaimAsync(user);
            //_userManager.Users.Remove(user);
            //_userManager.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }

}


/*

//[HttpPost]
        //public async Task<IActionResult> DeleteRole(string id)
        //{
        //    if (id != null)
        //    {
        //        IdentityRole role = new IdentityRole()
        //        {
        //            Id = id,
        //        };

        //        await _roleManager.DeleteAsync(role);
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        //[HttpGet]
        //public IActionResult Delete(string id)
        //{
        //    if (id == null || id == "")
        //    {
        //        return NotFound();
        //    }

        //    var categoryFromDb = _roleManager.FindByIdAsync(id);

        //    return View(categoryFromDb);
        //}

        //[HttpPost] // 
        //[ValidateAntiForgeryToken]
        //public IActionResult DeletePOST(string id)
        //{
        //    var obj = _dbContext.Roles.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }

        //    _dbContext.Roles.Remove(obj); // delete/remove 
        //    _dbContext.SaveChanges();

        //    TempData["success"] = "Category deleted role";

        //    return RedirectToAction(nameof(Index));

        //    //return View(obj);

    // brisanje
    //_roleManager.DeleteAsync()
    // ažuriranje
    //_roleManager.UpdateAsync()
    // dohvat Id-a
    //_roleManager.GetRoleIdAsync()
    // dohvat imena
    //_roleManager.GetRoleNameAsync()    

  */