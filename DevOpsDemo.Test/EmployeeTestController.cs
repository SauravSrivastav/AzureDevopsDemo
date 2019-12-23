using DevOpsDemo.Controllers;
using DevOpsDemo.Models;
using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace DevOpsDemo.Test
{
    public class EmployeeTestController
    {
        private EmployeeRepository repository;

        public EmployeeTestController()
        {
            repository = new EmployeeRepository();

        }

        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange
            var controller = new HomeController(this.repository);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange  
            var controller = new HomeController(this.repository);

            //Act  
            var result = controller.Index();

            //Assert  
            Assert.NotNull(result);
        }


        [Fact]
        public void Test_Index_GetEmployees_MatchData()
        {
            //Arrange  
            var controller = new HomeController(this.repository);

            //Act  
            var result = controller.Index();

            //Assert  
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<EmployeeViewModel>>(viewResult.ViewData.Model);

            Assert.Equal(3, model.Count);
            Assert.Equal(101, model[0].EmployeeId);
            Assert.Equal("DevOps Demo Name 1", model[0].Name);
        }
    }
}
