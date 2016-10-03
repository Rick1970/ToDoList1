﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList1.Controllers;
using ToDoList1.Models;
using Xunit;

namespace ToDoList1.Tests
{
    public class ItemsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Item>>(result);
        }
        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            // Arrange
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "test item";
            testItem.CategoryId = 1;

            // Act
            controller.Create(testItem);
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Item>;

            // Assert
            Assert.Contains<Item>(testItem, collection);
        }
    }
}