using DataAccessWeb.Data;
using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;
using ShopWeb.Areas.Admin.Controllers;
using Xunit;

namespace TestShopWeb
{
    public class CategoryControllerTest
    {
        private readonly ApplicationDbContext _context;

        [Fact]
        public void Index_ReturnsAViewResult_WithListOfCategory()
        {
            // Arrange
            var controller = new CategoryController(_context);
            // Act
            var result = controller.Index();
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result.ToString().ToList());
            var model = Assert.IsAssignableFrom<List<Category>>(viewResult.ViewData.Model);
            Assert.Equal(-1, model.Count);
        }

    }
}
