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
    public class ProjectsController : ApiController
    {
        // GET api/projects
        public HttpResponseMessage GetAll()
        {
            using (var db = new EventeamEntities())
            {
                var portfolios = db.Portfolios.ToList();

                var content = portfolios.Select(p => new
                {
                    p.PortfolioID,
                    p.ProjectName
                });

                return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
            }
        }

        // GET api/projects/1
        public HttpResponseMessage GetById(int id)
        {
            using (var db = new EventeamEntities())
            {
                var portfolio = db.Portfolios.FirstOrDefault(p => p.PortfolioID == id);

                if (portfolio != null)
                {
                    var content = new
                    {
                        portfolio.ProjectName,
                        FormatName = portfolio.Format.Name,
                        portfolio.Сustomer,
                        portfolio.Participants,
                        portfolio.Location,
                        portfolio.Task,
                        portfolio.Implementation,
                        portfolio.Result
                    };

                    return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
                }

                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        // GET api/projects/1
        public HttpResponseMessage GetByFormatId(int formatId)
        {
            using (var db = new EventeamEntities())
            {
                var portfolios = db.Portfolios.Where(p => p.Format.FormatID == formatId);

                if (portfolios.Count() != 0)
                {
                    var content = portfolios.Select(p => new
                    {
                        p.ProjectName,
                        FormatName = p.Format.Name,
                        p.Сustomer,
                        p.Participants,
                        p.Location,
                        p.Task,
                        p.Implementation,
                        p.Result
                    }).ToList();

                    return Request.CreateResponse(HttpStatusCode.OK, content, JsonMediaTypeFormatter.DefaultMediaType);
                }

                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}