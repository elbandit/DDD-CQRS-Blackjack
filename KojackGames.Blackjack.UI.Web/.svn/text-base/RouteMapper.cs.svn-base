using System.Web.Mvc;
using System.Web.Routing;

namespace KojackGames.Blackjack.UI.Web
{
    public class RouteMapper
    {
        public static void add_mappings_to(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}",
                 new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/", // URL with parameters
                new { controller = "Home", action = "Index" } // Parameter defaults
            );
        }
    }
}