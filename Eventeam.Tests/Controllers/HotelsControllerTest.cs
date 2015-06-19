using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;
using Newtonsoft.Json;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    public class HotelsControllerTest
    {
        #region GetAll

        [TestMethod]
        public void GetAll_should_return_hotels()
        {
            // Arrange
            var controller = new HotelsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:7000/api/hotels")
            };

            controller.Request.SetConfiguration(new HttpConfiguration());

            // Act
            var result = controller.GetAll();
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(content);
        }

        #endregion

        #region GetById

        [TestMethod]
        public void GetById_should_return_hotel_by_id()
        {
            // Arrange
            var controller = new HotelsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:7000/api/hotels/2")
            };

            controller.Request.SetConfiguration(new HttpConfiguration());

            // Act
            var result = controller.GetById(2);
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(content);
        }

        [TestMethod]
        public void GetById_should_return_not_found_hotel_by_id()
        {
            // Arrange
            var controller = new HotelsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:7000/api/hotels/0")
            };

            controller.Request.SetConfiguration(new HttpConfiguration());

            // Act
            var result = controller.GetById(0);
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.NotFound);
            Assert.IsNull(content);
        }

        #endregion

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