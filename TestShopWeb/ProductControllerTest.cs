﻿using Microsoft.AspNetCore.Mvc;
using ModelWeb.Models;
using WebShop.Areas.Admin.Controllers;
using Xunit;

namespace TestShopWeb
{
    public class ProductControllerTest
    {

        [Fact]
        public void Edit_ReturnsNotFoundResult_WhenIdIsZero()
        {
            // Arrange
            var controller = new ProductController();
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
            var controller = new ProductController();
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
            var controller = new ProductController();
            Product p = new Product()
            {
                Id = 1,
                Title = "NotNull",
                Active = true,
                CreatedDatetime = DateTime.Now,
                Quantity = 1,
                Price = 1,
                Description = ""
            };
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
