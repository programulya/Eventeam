using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace Eventeam.Controllers
{
    public class HotelsController : ApiController
    {
        // GET api/values
        public JsonResult<List<Hotel>> Get()
        {
            using (var db = new EventeamEntities())
            {
                var hotels = db.Hotels.ToList();

                return Json(hotels);
            }
        }

        // GET api/values/5
        public JsonResult<Hotel> Get(int id)
        {
            using (var db = new EventeamEntities())
            {
                var hotel = db.Hotels.FirstOrDefault(h => h.HotelID == id);

                return Json(hotel);
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
