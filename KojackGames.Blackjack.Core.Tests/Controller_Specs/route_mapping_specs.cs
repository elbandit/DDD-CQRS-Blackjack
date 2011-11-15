using System.Web.Routing;
using KojackGames.Blackjack.UI.Web;
using KojackGames.Blackjack.UI.Web.Controllers;
using KojackGames.Blackjack.UI.Web.Controllers.GamePlay;
using Machine.Specifications;
using MvcContrib.TestHelper;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Controller_Specs
{
    [Subject(typeof(RouteMapper), "route mapper")]
    public class route_mapping_specs
    {
        private Establish context = () =>
        {
            var routes = RouteTable.Routes;
            routes.Clear();
            RouteMapper.add_mappings_to(routes);
        };

        private It should_map_the_bet_route = () =>
        {
            "~/bet/".Route().ShouldMapTo<BetController>();
        };      
    }
}
