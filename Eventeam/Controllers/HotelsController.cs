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
        public IEnumerable<Hotel> Get()
        {
            using (var db = new EventeamEntities())
            {
                var hotels = db.Hotels;

                return hotels.AsEnumerable();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
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
        }
    }
}
