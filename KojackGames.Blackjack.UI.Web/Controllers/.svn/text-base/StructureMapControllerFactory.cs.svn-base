using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace KojackGames.Blackjack.UI.Web.Controllers
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
           return ObjectFactory.GetInstance(controllerType) as IController;
        }
    }
}