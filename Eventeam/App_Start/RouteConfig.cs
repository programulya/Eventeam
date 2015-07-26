using System.Web.Mvc;
using System.Web.Routing;

namespace Eventeam
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.gif/{*pathInfo}");
            routes.IgnoreRoute("{resource}.jpg/{*pathInfo}");
            routes.IgnoreRoute("{resource}.png/{*pathInfo}");
            routes.IgnoreRoute("{resource}.psd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional});
        }
    }
}