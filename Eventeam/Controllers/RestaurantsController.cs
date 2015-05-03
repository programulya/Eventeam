using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class RestaurantsController : ApiController
    {
        // GET api/restaurants
        public HttpResponseMessage GetAll()
        {
            using (var db = new EventeamEntities())
            {
                var restaurants = db.Restaurants.ToList();

                var content = restaurants.Select(r => new
                {
                    r.Name,
                    r.Platform.Address,
                    KitchenName = r.Kitchen.Name
                }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
            }
        }
    }
}