using System;
using Xunit;
using NinjaProject;
using NinjaProject.Controllers;
using NinjaProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace NinjaProject.Test
{
    public class ClanControllerTest
    {
        protected ClanController ControllerUnderTest { get; }

        public ClanControllerTest()
        {
            ControllerUnderTest = new ClanController();
        }

        [Fact]
        public async void Should_return_OkObject_with_clans()
        {
            //Arrange
            var expectedClans = new Clan[]
            {
                new Clan { Name = "Test Clan 1"},
                new Clan { Name = "Test Clan 2"},
                new Clan { Name = "Test Clan 3"}
            };
            //Act
            var result = await ControllerUnderTest.ReadAllAsync();
            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Same(expectedClans, okresult.Value);
        }
    }
}
