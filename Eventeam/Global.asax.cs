using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Eventeam
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var db = new EventeamEntities())
            {
                var platforms = db.Platforms.ToList();

                foreach (var platform in platforms)
                {
                    Console.WriteLine("{0} {1} {2} {3}", platform.Geography, platform.Name, platform.Level,
                        platform.Location);
                }
            }
        }
    }
}