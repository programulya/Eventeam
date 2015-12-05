﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Eventeam.Models;
using Eventeam.Services;

namespace Eventeam.Controllers.Api
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

                    content.Add(new HotelViewModel
                    {
                        HotelId = hotel.HotelID,
                        HotelName = hotel.Name,
                        PlatformCityName = hotel.Platform.City.Name,
                        PlatformAddress = hotel.Platform.Address,
                        MainPhoto = mainPhoto
                    });
                }

                return Request.CreateResponse(HttpStatusCode.OK, content.ToList(),
                    JsonMediaTypeFormatter.DefaultMediaType);
            }
        }

        // GET api/hotels/1
        [Obsolete]
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