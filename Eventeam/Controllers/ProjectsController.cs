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
using Newtonsoft.Json;

namespace Eventeam.Controllers
{
    public class ProjectsController : Controller
    {
        const string ImagesPortfolioPath = "~/images/portfolio/";
        const string ImgFile = "-.jpg";

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
                    var directories = Directory.GetDirectories(Server.MapPath(ImagesPortfolioPath)).ToList();
                    var directory = directories.FirstOrDefault(d => d.EndsWith(portfolio.ShortName));

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
                        MainPhotoList = new List<ProjectPhotoViewModel>(),
                        GalleryPhotoList = new List<ProjectPhotoViewModel>()
                    };
                    
                    if (directory != null)
                    {
                        var photos = Directory.GetFiles(directory).ToList();

                        if (photos.Count != 0)
                        {
                            foreach (var p in photos)
                            {
                                if (p.EndsWith(ImgFile))
                                {
                                    var name = Path.GetFileName(p);
                                    var link = ImagesPortfolioPath + portfolio.ShortName + "/" + name;
                                    var linkResponsive = ImagesPortfolioPath + portfolio.ShortName + "/" + name.Substring(0, name.Length - ImgFile.Length) + "--400x250.jpg";
                                    var alt = content.ProjectName;

                                    content.MainPhotoList.Add(new ProjectPhotoViewModel
                                    {
                                        Link = link,
                                        Alt = alt
                                    });

                                    content.GalleryPhotoList.Add(new ProjectPhotoViewModel
                                    {
                                        Link = link,
                                        LinkResponsive = linkResponsive,
                                        Alt = content.ProjectName
                                    });
                                }
                            }
                        }
                    }

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}