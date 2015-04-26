using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;
using Newtonsoft.Json;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    public class ProjectsControllerTest
    {
        [TestMethod]
        public void Get_should_return_projects()
        {
            // Arrange
            var controller = new ProjectsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5000/api/projects")
            };

            controller.Request.SetConfiguration(new HttpConfiguration());

            // Act
            var result = controller.GetById(1);
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(content);
        }

        [TestMethod]
        public void GetById_should_return_project_by_id()
        {
            // Arrange
            var controller = new ProjectsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5000/api/projects")
            };

            controller.Request.SetConfiguration(new HttpConfiguration());

            // Act
            var result = controller.GetById(1);
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNotNull(content);
        }

        [TestMethod]
        public void GetById_should_return_not_found_project_by_id()
        {
            // Arrange
            var controller = new ProjectsController
            {
                Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5000/api/projects")
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
    }
}