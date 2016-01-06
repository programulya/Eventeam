using System.Collections.Generic;
using System.Web.Mvc;
using Eventeam.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Controllers;
using Eventeam.Models;
using Eventeam.Services;
using Moq;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    public class ProjectsControllerTests
    {
        #region Init

        private Mock<IImagesService> _imagesServiceMock = new Mock<IImagesService>();

        [TestInitialize]
        public void TestInit()
        {
            _imagesServiceMock = new Mock<IImagesService>();
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void TestCleanup()
        {
        }

        #endregion

        #region 'Portfolio' method tests

        [TestMethod]
        public void Portfolio_should_return_portfolio()
        {
            // Arrange
            var controller = new ProjectsController(_imagesServiceMock.Object);

            // Act
            var result = controller.Portfolio();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (ViewResult));
        }

        #endregion

        #region 'PortfolioItem' method tests

        [TestMethod]
        public void PortfolioItem_should_return_project_by_id()
        {
            // Arrange
            var controller = new ProjectsController(_imagesServiceMock.Object);

            // Act
            var result = controller.PortfolioItem(1);
            _imagesServiceMock.Setup(i => i
                .GetPortfolioPhotos(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(new List<ImageViewModel>
                {
                    new ImageViewModel {Link = "Link", LinkResponsive = "LinkResponsive", Alt = "Alt"}
                });

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (ViewResult));

            _imagesServiceMock.Verify(i => i.GetPortfolioPhotos(It.IsAny<string>(), It.IsAny<string>()));
        }

        [TestMethod]
        public void PortfolioItem_should_return_not_found_project_by_id()
        {
            // Arrange
            var controller = new ProjectsController(new ImagesService());

            // Act
            var result = controller.PortfolioItem(0);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (HttpNotFoundResult));
        }

        #endregion
    }
}