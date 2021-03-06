﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Eventeam.Contracts;
using Eventeam.Database;
using Eventeam.Models;

namespace Eventeam.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IImagesService _imagesService;

        public ProjectsController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        // TODO: Move to repositories
        public ActionResult PortfolioItem(int id)
        {
            using (var db = new EventeamContext())
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
                    var sliderPhotos = _imagesService.FilterPortfolioSliderPhotos(portfolioPhotos);

                    content.MainPhotoList = sliderPhotos;
                    content.GalleryPhotoList = portfolioPhotos;

                    return View(content);
                }

                return HttpNotFound();
            }
        }
    }
}