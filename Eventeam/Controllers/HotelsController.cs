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
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class HotelsController : ApiController
    {
        // GET api/hotels
        public HttpResponseMessage GetAll()
        {
            using (var db = new EventeamEntities())
            {
                var hotels = db.Hotels.ToList();

                var content = hotels.Select(h => new
                {
                    h.Name,
                    h.Capacity,
                    h.Entertainment
                }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
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