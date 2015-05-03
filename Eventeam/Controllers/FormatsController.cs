﻿using System;
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
    public class FormatsController : ApiController
    {
        // GET api/formats
        public HttpResponseMessage GetAll()
        {
            using (var db = new EventeamEntities())
            {
                var formats = db.Formats.ToList();

                var content = formats.Select(p => new
                {
                    p.FormatID,
                    p.Name
                }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
            }
        }
    }
}