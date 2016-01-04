using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Controllers;
using Eventeam.Controllers.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;
using Newtonsoft.Json;
using PlatformsController = Eventeam.Controllers.Api.PlatformsController;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    [Ignore]
    public class PlatformsControllerTests
    {
        #region GetAll

        [TestMethod]
        public void GetAll_should_return_platforms()
        {
            // Arrange
            var controller = new PlatformsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:7000/api/platforms")
            };

            HttpContext.Current = new HttpContext(
                new HttpRequest("", "http://localhost:7000/api/platforms", ""),
                new HttpResponse(new StringWriter()));

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
        public void GetById_should_return_platform_by_id()
        {
            // Arrange
            var controller = new PlatformsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:7000/api/platforms/2")
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
        public void GetById_should_return_not_found_platform_by_id()
        {
            // Arrange
            var controller = new PlatformsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:7000/api/platforms/0")
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