using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventeam.Models;
using Eventeam.Services;

namespace Eventeam.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly ImagesService _imagesService = new ImagesService();

        public ActionResult Platforms()
        {
            return View();
        }

        public ActionResult Hotel(int id)
        {
            using (var db = new EventeamEntities())
            {
                var hotel = db.Hotels.FirstOrDefault(p => p.HotelID == id);

                if (hotel != null)
                {
                    var photos = _imagesService.GetPlatformPhotos(hotel.FolderName, hotel.Name);
                    var mainPhoto = _imagesService.FilterPlatformMainPhoto(photos);
                    var platformPhotos = _imagesService.FilterPlatformPhotos(photos);

                    var content = new HotelViewModel
                    {
                        HotelId = hotel.HotelID,
                        HotelCategoryName = hotel.HotelCategory.Name,
                        HotelName = hotel.Name,
                        HotelSite = hotel.Site,
                        RoomCount = hotel.RoomCount,
                        Capacity = hotel.Capacity,
                        Entertainment = hotel.Entertainment,
                        Rehabilitation = hotel.Rehabilitation,
                        Parking = hotel.Parking,
                        Internet = hotel.Internet,
                        Other = hotel.Other,

                        PlatformName = hotel.Platform.Name,
                        PlatformCityName = hotel.Platform.City.Name,
                        PlatformLevelName = hotel.Platform.Level.Name,
                        PlatformLocationName = hotel.Platform.Location.Name,
                        PlatformGeography = hotel.Platform.Geography,
                        PlatformAddress = hotel.Platform.Address,
                        PlatformSite = hotel.Platform.Site,

                        MainPhoto = mainPhoto,
                        PlatformPhotos = platformPhotos
                    };

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}