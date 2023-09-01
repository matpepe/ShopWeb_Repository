using DataAccessWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;
using System.Security.Claims;

namespace ShopWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Category.ToList();

            //var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //@ViewBag.CurrentUserId = userId;

            return View(categories);
        }

        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var category = _dbContext.Category.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            string userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //@ViewBag.CurrentUserId = userId;
            if (ModelState.IsValid)
            {
                category.ApplicationUser = userId;
                _dbContext.Category.Add(category);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _dbContext.Category.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update(category);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var category = _dbContext.Category.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var category = _dbContext.Category.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            _dbContext.Category.Remove(category);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
