using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KojackGames.Blackjack.Infrastructure.Nhibernate;
using KojackGames.Blackjack.UI.Web.Controllers;
using StructureMap;

namespace KojackGames.Blackjack.UI.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {            
            RouteMapper.add_mappings_to(routes);
        }

        protected void Application_Start()
        {
            SessionFactory.Init();

            AreaRegistration.RegisterAllAreas();

            BootStrapper.configure_dependencies();
            
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());

            RegisterRoutes(RouteTable.Routes);
        }
    }
}