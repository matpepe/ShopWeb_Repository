using DataAccessWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var products = _dbContext.Product.ToList();

            return View(products);
        }

        public IActionResult Details(int id)
        {
            if (id == 0) return NotFound();

            var product = _dbContext.Product.FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {

            if (ModelState.IsValid)
            {
                string wwwRootPath = "wwwroot";
                string fileName = product.ImageFile.FileName;
                product.ImageName = fileName;
                string path = wwwRootPath + "/Images/" + fileName;
                // spremiti na file system
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    product.ImageFile.CopyTo(fileStream);
                }

                _dbContext.Product.Add(product);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        public IActionResult Edit(int id)
        {
            if (id == 0) return NotFound();

            var product = _dbContext.Product.FirstOrDefault(x => x.Id == id);

            if (product == null) return NotFound();


            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (product == null || product.Id == 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _dbContext.Update(product);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var product = _dbContext.Product.FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == 0) return NotFound();

            var product = _dbContext.Product.FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            _dbContext.Remove(product);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
