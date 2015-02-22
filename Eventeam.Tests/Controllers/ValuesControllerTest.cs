using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            var list = result as IList<string> ?? result.ToList();
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual("value1", list.ElementAt(0));
            Assert.AreEqual("value2", list.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            // Assert
            controller.Post("value");
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            // Assert
            controller.Put(5, "value");
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            // Assert
            controller.Delete(5);
        }
    }
}
