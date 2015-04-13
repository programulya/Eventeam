using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;

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

            // Assert
            Assert.IsNotNull(result);
            var list = result;
            var hotels = list as IList<Hotel> ?? list.ToList();
            Assert.AreEqual(2, hotels.Count());
            Assert.AreEqual("value1", hotels.ElementAt(0));
            Assert.AreEqual("value2", hotels.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller = new HotelsController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
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
        }
    }
}
