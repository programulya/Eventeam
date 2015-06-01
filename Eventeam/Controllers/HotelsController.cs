using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Eventeam.Models;
using Eventeam.Services;
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class HotelsController : ApiController
    {
        private readonly ImagesService _imagesService = new ImagesService();

        // GET api/hotels
        public HttpResponseMessage GetAll()
        {
            using (var db = new EventeamEntities())
            {
                var hotels = db.Hotels.ToList();
                var content = new List<HotelViewModel>();

                foreach (var hotel in hotels)
                {
                    var photos = _imagesService.GetPlatformPhotos(hotel.FolderName, hotel.Name);
                    var mainPhoto = _imagesService.FilterPlatformMainPhoto(photos);
                    var platformPhotos = _imagesService.FilterPlatformPhotos(photos);

                    content.Add(new HotelViewModel
                    {
                        HotelID = hotel.HotelID,
                        PlatformID = hotel.PlatformID,
                        HotelCategoryName = hotel.HotelCategory.Name,
                        Name = hotel.Name,
                        Site = hotel.Site,
                        RoomCount = hotel.RoomCount,
                        Capacity = hotel.Capacity,
                        Entertainment = hotel.Entertainment,
                        Rehabilitation = hotel.Rehabilitation,
                        Parking = hotel.Parking,
                        Internet = hotel.Internet,
                        Other = hotel.Other,
                        FolderName = hotel.FolderName,
                        MainPhoto = mainPhoto,
                        PlatformPhotos = platformPhotos
                    });
                }

                return Request.CreateResponse(HttpStatusCode.OK, content.ToList(), JsonMediaTypeFormatter.DefaultMediaType);
            }
        }

        // GET api/hotels/1
        public HttpResponseMessage GetById(int id)
        {
            using (var db = new EventeamEntities())
            {
                var hotel = db.Hotels.FirstOrDefault(h => h.HotelID == id);

                if (hotel != null)
                {
                    var content = new
                    {
                        hotel.Name,
                        hotel.Capacity,
                        hotel.Entertainment
                    };

                    return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
                }

                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        /*// POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
    }
}