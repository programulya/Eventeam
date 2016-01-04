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

        public ActionResult Platform(int id)
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
                        Name = platform.Name,
                        CityName = platform.City.Name,
                        LevelName = platform.Level.Name,
                        LocationName = platform.Location.Name,
                        Geography = platform.Geography,
                        Address = platform.Address,
                        Site = platform.Site,
                        MainPhoto = mainPhoto,
                        PlatformPhotos = platformPhotos,
                    };

                    var hotel = db.Hotels.FirstOrDefault(h => h.PlatformID == id);
                    if (hotel != null)
                    {
                        content.Hotel = new HotelViewModel
                        {
                            HotelId = hotel.HotelID,
                            CategoryName = hotel.HotelCategory.Name,
                            Name = hotel.Name,
                            Site = hotel.Site,
                            RoomCount = hotel.RoomCount,
                            Capacity = hotel.Capacity,
                            Entertainment = hotel.Entertainment,
                            Rehabilitation = hotel.Rehabilitation,
                            Parking = hotel.Parking,
                            Internet = hotel.Internet,
                            Other = hotel.Other
                        };
                    }

                    var restaurants = db.Restaurants.Where(p => p.PlatformID == id);
                    if (restaurants.Any())
                    {
                        content.Restaurants = new List<RestaurantViewModel>();

                        foreach (var rest in restaurants)
                        {
                            var c = new RestaurantViewModel
                            {
                                RestaurantId = rest.RestaurantID,
                                Name = rest.Name,
                                ClassificationName = rest.Classification.Name,
                                KitchenName = rest.Kitchen.Name,
                                Banquet = rest.Banquet ?? 0,
                                Buffet = rest.Buffet ?? 0,
                                TotalSquare = rest.TotalSquare ?? 0,
                                Seating = rest.Seating ?? 0
                            };

                            content.Restaurants.Add(c);
                        }
                    }

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}