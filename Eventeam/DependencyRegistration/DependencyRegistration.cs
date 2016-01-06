using System.Web.Http;
using System.Web.Mvc;
using Eventeam.Contracts;
using Eventeam.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;

namespace Eventeam.DependencyRegistration
{
    public class DependencyRegistration
    {
        public static void Register()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            container.Register<IImagesService, ImagesService>();
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}