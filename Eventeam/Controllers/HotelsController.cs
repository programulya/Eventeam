using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class HotelsController : ApiController
    {
        // TODO return HttpResponseMessage
        // GET api/hotels
        public JsonResult<List<Hotel>> Get()
        {
            using (var db = new EventeamEntities())
            {
                var hotels = db.Hotels.ToList();

                var content = hotels.Select(h => new Hotel
                {
                    Name = h.Name,
                    Capacity = h.Capacity,
                    Entertainment = h.Entertainment
                }).ToList();

                return Json(content);
            }
        }

        // GET api/hotels/1
        public JsonResult<Hotel> GetById(int id)
        {
            using (var db = new EventeamEntities())
            {
                var content = new Hotel();
                var hotel = db.Hotels.FirstOrDefault(h => h.HotelID == id);

                if (hotel != null)
                {
                    content = new Hotel
                    {
                        Name = hotel.Name,
                        Capacity = hotel.Capacity,
                        Entertainment = hotel.Entertainment
                    };
                }

                return Json(content);
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