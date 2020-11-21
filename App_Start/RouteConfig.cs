using System.Web.Mvc;
using System.Web.Routing;

namespace MGRescue_System
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
        name: "callbackUrl",
        url: "Account/ConfirmEmail",
        defaults: new { controller = "Account", action = "ConfirmEmail" }
    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}