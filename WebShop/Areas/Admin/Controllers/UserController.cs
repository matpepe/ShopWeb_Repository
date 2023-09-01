using DataAccessWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        ApplicationDbContext _dbContext;

        public UserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var users = _dbContext.Users.ToList();
            return View(users);
        }

        public IActionResult Update(string id)
        {

            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost]
        public IActionResult Update(string Id, string FirstName, string LastName)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == Id);

            user.FirstName = FirstName;
            user.LastName = LastName;
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(string id)
        {
            if (id == "") return NotFound();

            var user = _dbContext.Users.FirstOrDefault(p => p.Id == id);

            if (user == null) return NotFound();

            return View(user);
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            if (id == "")
                return NotFound();

            var user = _dbContext.Users.FirstOrDefault(p => p.Id == id);

            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            if (id == "")
                return NotFound();

            var user = _dbContext.Users.FirstOrDefault(p => p.Id == id);

            if (user == null) return NotFound();

            _dbContext.Remove(user);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
