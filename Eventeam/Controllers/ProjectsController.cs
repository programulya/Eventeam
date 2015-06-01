using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Eventeam.Models;
using Eventeam.Services;
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ImagesService _imagesService = new ImagesService();

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
                        Result = portfolio.Result,
                        MainPhotoList = new List<ImageViewModel>(),
                        GalleryPhotoList = new List<ImageViewModel>()
                    };

                    var portfolioPhotos = _imagesService.GetPortfolioPhotos(portfolio.FolderName, portfolio.ProjectName);

                    foreach (var p in portfolioPhotos)
                    {
                        content.MainPhotoList.Add(new ImageViewModel
                        {
                            Link = p.Link,
                            Alt = p.Alt
                        });

                        content.GalleryPhotoList.Add(p);
                    }

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}