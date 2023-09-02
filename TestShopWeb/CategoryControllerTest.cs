using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;
using ShopWeb.Areas.Admin.Controllers;
using Xunit;

namespace TestShopWeb
{
    public class CategoryControllerTest
    {
        [Fact]
        public void Index_ReturnsAViewResult_WithListOfPeople()
        {
            // Arrange
            var controller = new CategoryController();
            // Act
            var result = controller.Index();
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Category>>(viewResult.ViewData.Model);
            Assert.Equal(-1, model.Count);
        }

    }
}
