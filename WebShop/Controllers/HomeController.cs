using DataAccessWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ModelWeb.Models;
using System.Diagnostics;

namespace ShopWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var products = _dbContext.Product.ToList();

            return View(products);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult Product(int? categoryId)
        {
            List<Product> products = _dbContext.Product.ToList();

            if (categoryId != null)
            {
                products = (from product in _dbContext.Product
                            join prodCat in _dbContext.ProductCategory on product.Id equals prodCat.ProductId
                            where prodCat.CategoryId == categoryId
                            select new Product
                            {
                                Id = product.Id,
                                Title = product.Title,
                                Description = product.Description,
                                Quantity = product.Quantity,
                                Price = product.Price,
                                ImageName = product.ImageName,
                                ImageFile = product.ImageFile
                            }).ToList();
            }

            ViewBag.Categories = _dbContext.Category.Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Title
            }).ToList();

            return View(products);
        }

        [Authorize]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}