using DataAccessWeb.Data;
using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;
using WebShop.Areas.Admin.Controllers;
using Xunit;

namespace TestShopWeb
{
    public class ProductControllerTest
    {
        private readonly ApplicationDbContext _context;

        public static Product p = new Product()
        {
            Id = 1,
            Title = "NotNull",
            Active = true,
            CreatedDatetime = DateTime.Now,
            Quantity = 1,
            Price = 1,
            Description = ""
        };

        [Fact]
        public void Edit_ReturnsNotFoundResult_WhenIdIsZero()
        {
            // Arrange
            var controller = new ProductController(_context);
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
            var p = new Product
            {
                Id = 1,
                Title = "NotNull",
                Active = true,
                CreatedDatetime = DateTime.Now,
                Quantity = 1,
                Price = 1,
                Description = ""
            };
            // Arrange
            var controller = new ProductController(_context);
            //int id = 2;
            // Act
            var result = controller.Edit(p.Id);
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Product>(viewResult);

            Assert.Null(model);
        }

        [Fact]
        public void Add_AddsProductAndReturnsARedirect_WhenModelIsNotNull()
        {
            // Arrange
            var p = new Product
            {
                Id = 1,
                Title = "NotNull",
                Active = true,
                CreatedDatetime = DateTime.Now,
                Quantity = 1,
                Price = 1,
                Description = ""
            };

            var controller = new ProductController(_context);
            // Act
            var result = controller.Create(p);
            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        [Fact]
        public void Add_AddsProductAndReturnsBadRequest_WhenModelIsNull()
        {
            // Arrange
            var controller = new ProductController(_context);
            // Act
            var result = controller.Create(null);
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult);
        }

    }
}
