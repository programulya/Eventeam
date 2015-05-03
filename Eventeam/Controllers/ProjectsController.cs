using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Eventeam.Models;
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult PortfolioItem(int id)
        {
            using (var db = new EventeamEntities())
            {
                var portfolio = db.Portfolios.FirstOrDefault(p => p.PortfolioID == id);

                if (portfolio != null)
                {
                    var content = new ProjectViewModel
                    {
                        ProjectName = portfolio.ProjectName,
                        FormatName = portfolio.Format.Name,
                        Сustomer = portfolio.Сustomer,
                        Participants = portfolio.Participants,
                        Location = portfolio.Location,
                        Task = portfolio.Task,
                        Implementation = portfolio.Implementation,
                        Result = portfolio.Result
                    };

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}