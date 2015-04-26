using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;
using Newtonsoft.Json;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    public class HotelsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new HotelsController();

            // Act
            var result = controller.Get();
            var hotels = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(hotels);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller = new HotelsController();

            // Act
            var result = controller.Get(2);
            var hotel = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(hotel);
        }

        /*[TestMethod]
        public void Post()
        {
            // Arrange
            var controller = new HotelsController();

            // Act
            // Assert
            controller.Post("value");
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            var controller = new HotelsController();

            // Act
            // Assert
            controller.Put(5, "value");
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var controller = new HotelsController();

            // Act
            // Assert
            controller.Delete(5);
        }*/
    }
}
