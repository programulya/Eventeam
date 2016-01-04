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
                var platform = db.Platforms.FirstOrDefault(p => p.PlatformID == id);

                if (platform != null)
                {
                    var photos = _imagesService.GetPlatformPhotos(platform.FolderName, platform.Name);
                    var mainPhoto = _imagesService.FilterPlatformMainPhoto(photos);
                    var platformPhotos = _imagesService.FilterPlatformPhotos(photos);

                    var content = new PlatformViewModel
                    {
                        PlatformId = platform.PlatformID,
                        PlatformName = platform.Name,
                        PlatformCityName = platform.City.Name,
                        PlatformLevelName = platform.Level.Name,
                        PlatformLocationName = platform.Location.Name,
                        PlatformGeography = platform.Geography,
                        PlatformAddress = platform.Address,
                        PlatformSite = platform.Site,

                        Hotels = new List<HotelViewModelNew>(),
                        /*HotelId = hotel.HotelID,
                        HotelCategoryName = hotel.HotelCategory.Name,
                        HotelName = hotel.Name,
                        HotelSite = hotel.Site,
                        RoomCount = hotel.RoomCount,
                        Capacity = hotel.Capacity,
                        Entertainment = hotel.Entertainment,
                        Rehabilitation = hotel.Rehabilitation,
                        Parking = hotel.Parking,
                        Internet = hotel.Internet,
                        Other = hotel.Other,*/


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