using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eventeam.Models;

namespace Eventeam.Controllers
{
    public class PlatformsController: Controller
    {
        public ActionResult Platforms()
        {
            return View();
        }

        public ActionResult PlatformItem(int id)
        {
            return View();
        }
    }
}