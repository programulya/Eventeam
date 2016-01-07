using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Eventeam.Contracts;
using Eventeam.Models;

namespace Eventeam.Controllers.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IImagesService _imagesService;

        public RestaurantsController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }

        // GET api/restaurants
        public HttpResponseMessage GetAll()
        {
            try
            {
                using (var db = new EventeamEntities())
                {
                    var restaurants = db.Restaurants.ToList();
                    var content = new List<RestaurantViewModel>();

                    foreach (var restaurant in restaurants)
                    {
                        var photos = _imagesService.GetPlatformPhotos(restaurant.FolderName, restaurant.Name);
                        var mainPhoto = _imagesService.FilterPlatformMainPhoto(photos);

                        content.Add(new RestaurantViewModel
                        {
                            RestaurantId = restaurant.RestaurantID,
                            Name = restaurant.Name,
                            Type = restaurant.RestaurantType.Name,
                            ClassificationName = restaurant.Classification.Name,
                            KitchenName = restaurant.Kitchen.Name,
                            Banquet = restaurant.Banquet,
                            Buffet = restaurant.Buffet,
                            TotalSquare = restaurant.TotalSquare,
                            Seating = restaurant.Seating,
                            MainPhoto = mainPhoto,
                            PlatformPhotos = photos
                        });
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
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