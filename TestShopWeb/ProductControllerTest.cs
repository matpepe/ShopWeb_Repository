using DataAccessWeb.Data;
using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;
using WebShop.Areas.Admin.Controllers;
using Xunit;

namespace TestShopWeb
{
    public class ProductControllerTest
    {
        private ApplicationDbContext _dbContext;

        public ProductControllerTest(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        Product p;

        //public ProductControllerTest()
        //{
        //    p = new Product();
        //    p.Active = true;
        //    p.Price = 100;
        //    p.Quantity = 1;
        //    p.Title = "TSHIRT";
        //    p.CreatedDatetime = DateTime.Now;
        //}

        [Fact]
        public void Edit_ReturnsNotFoundResult_WhenIdIsZero()
        {
            // Arrange
            var controller = new ProductController(null);
            int id = 0;
            // Act
            var result = controller.Edit(id);
            // Assert
            var notFoundResult = Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, notFoundResult.StatusCode);
        }

        [Fact]
        public void Details_GetProductDetails_WhenModelIsNotNull()
        {
            // Arrange
            var controller = new ProductController(_dbContext);
            int id = 2;
            // Act
            var result = controller.Edit(id);
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Product>(viewResult.ViewData.Model);

            Assert.NotNull(model);
        }

        [Fact]
        public void Add_AddsProductAndReturnsARedirect_WhenModelIsNotNull()
        {
            // Arrange
            var controller = new ProductController(_dbContext);
            // Act
            var result = controller.Create(p);
            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        //[Fact]
        //public void Add_AddsProductAndReturnsBadRequest_WhenModelIsNull()
        //{
        //    // Arrange
        //    var controller = new ProductController();
        //    // Act
        //    var result = controller.Create(null);
        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //}

    }
}
