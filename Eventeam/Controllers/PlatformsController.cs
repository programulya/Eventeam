using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventeam.Contracts;
using Eventeam.Models;
using Eventeam.Services;

namespace Eventeam.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly IImagesService _imagesService;

        public PlatformsController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }

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

                        if (hotel.Rooms.Any())
                        {
                            content.Hotel.Rooms = new List<RoomViewModel>();

                            foreach (var r in hotel.Rooms)
                            {
                                var c = new RoomViewModel
                                {
                                    RoomId = r.RoomID,
                                    Name = r.Name,
                                    RoomCategoryName = r.RoomCategory.Name,
                                    RoomTypeName = r.RoomType.Name,
                                    Quantity = r.Quantity
                                };

                                content.Hotel.Rooms.Add(c);
                            }
                        }
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
                                Banquet = rest.Banquet,
                                Buffet = rest.Buffet,
                                TotalSquare = rest.TotalSquare,
                                Seating = rest.Seating
                            };

                            content.Restaurants.Add(c);
                        }
                    }

                    var halls = db.Halls.Where(p => p.PlatformID == id);
                    if (halls.Any())
                    {
                        content.Halls = new List<HallViewModel>();

                        foreach (var h in halls)
                        {
                            var c = new HallViewModel
                            {
                                HallId = h.HallID,
                                Name = h.Name,
                                TotalSquare = h.TotalSquare,
                                Theater = h.Theater,
                                Class = h.Class,
                                PPlanting = h.PPlanting,
                                MeetingRoom = h.MeetingRoom,
                                Banquet = h.Banquet,
                                Buffet = h.Buffet,
                                Equipment = h.Equipment
                            };

                            content.Halls.Add(c);
                        }
                    }

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}