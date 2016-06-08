using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Eventeam.Contracts;
using Eventeam.Database;
using Eventeam.Models;
using Eventeam.Services;

namespace Eventeam.Controllers.Api
{
    public class PlatformsController : ApiController
    {
        private readonly IImagesService _imagesService;

        public PlatformsController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }

        // GET api/platforms
        public HttpResponseMessage GetAll()
        {
            try
            {
                using (var db = new EventeamContext())
                {
                    var platforms = db.Platforms.ToList();
                    var content = new List<PlatformInfoViewModel>();

                    foreach (var platform in platforms)
                    {
                        var photos = _imagesService.GetPlatformPhotos(platform.FolderName, platform.Name);
                        var mainPhoto = _imagesService.FilterPlatformMainPhoto(photos);

                        content.Add(new PlatformInfoViewModel
                        {
                            PlatformId = platform.PlatformID,
                            Name = platform.Name,
                            CityName = platform.City.Name,
                            Address = platform.Address,
                            MainPhoto = mainPhoto
                        });
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, content.ToList(),
                        JsonMediaTypeFormatter.DefaultMediaType);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message,
                    JsonMediaTypeFormatter.DefaultMediaType);
            }
        }
    }
}