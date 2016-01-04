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
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;
using Newtonsoft.Json;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    [Ignore]
    public class ProjectsControllerTests
    {
        #region Portfolio 

        [TestMethod]
        public void Portfolio_should_return_portfolio()
        {
            // Arrange
            var controller = new ProjectsController();

            // Act
            var result = controller.Portfolio();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (ViewResult));
        }

        #endregion

        #region PortfolioItem

        [TestMethod]
        public void PortfolioItem_should_return_project_by_id()
        {
            // Arrange
            var controller = new ProjectsController();

            // Act
            var result = controller.PortfolioItem(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (ViewResult));
        }

        [TestMethod]
        public void PortfolioItem_should_return_not_found_project_by_id()
        {
            // Arrange
            var controller = new ProjectsController();

            // Act
            var result = controller.PortfolioItem(0);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (HttpNotFoundResult));
        }

        #endregion
    }
}