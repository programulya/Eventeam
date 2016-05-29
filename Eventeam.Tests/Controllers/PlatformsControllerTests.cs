using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Eventeam.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eventeam.Models;
using Moq;
using PlatformsController = Eventeam.Controllers.Api.PlatformsController;

namespace Eventeam.Tests.Controllers
{
    [TestClass]
    public class PlatformsControllerTests
    {
        #region Init

        private Mock<IImagesService> _imagesServiceMock = new Mock<IImagesService>();
        private const string ApiPlatforms = "http://localhost:7000/api/platforms";

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

        #region 'GetAll' method tests

        [TestMethod]
        public void GetAll_should_return_status_code_ok_and_platforms()
        {
            // Arrange
            var controller = new PlatformsController(_imagesServiceMock.Object)
            {
                Request = new HttpRequestMessage(HttpMethod.Get, ApiPlatforms)
            };

            HttpContext.Current = new HttpContext(
                new HttpRequest("", ApiPlatforms, ""),
                new HttpResponse(new StringWriter()));

            controller.Request.SetConfiguration(new HttpConfiguration());

            _imagesServiceMock.Setup(i => i
                .GetPlatformPhotos(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(new List<ImageViewModel>
                {
                    new ImageViewModel {Link = "Link", LinkResponsive = "LinkResponsive", Alt = "Alt"}
                });

            _imagesServiceMock.Setup(i => i
                .FilterPlatformMainPhoto(It.IsAny<IEnumerable<ImageViewModel>>()))
                .Returns(new ImageViewModel {Link = "LinkMain", LinkResponsive = "LinkResponsiveMain", Alt = "AltMain"});

            // Act
            var result = controller.GetAll();
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.IsNotNull(content);

            _imagesServiceMock.Verify(i => i.GetPlatformPhotos(It.IsAny<string>(), It.IsAny<string>()));
            _imagesServiceMock.Verify(i => i.FilterPlatformMainPhoto(It.IsAny<IEnumerable<ImageViewModel>>()));
        }

        [TestMethod]
        public void GetAll_should_return_status_code_internal_server_error_on_exception()
        {
            // Arrange
            var controller = new PlatformsController(null)
            {
                Request = new HttpRequestMessage(HttpMethod.Get, ApiPlatforms)
            };

            HttpContext.Current = new HttpContext(
                new HttpRequest("", ApiPlatforms, ""),
                new HttpResponse(new StringWriter()));

            controller.Request.SetConfiguration(new HttpConfiguration());

            // Act
            var result = controller.GetAll();
            var content = result.Content;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.InternalServerError, result.StatusCode);
            Assert.IsNotNull(content);
        }

        #endregion
    }
}