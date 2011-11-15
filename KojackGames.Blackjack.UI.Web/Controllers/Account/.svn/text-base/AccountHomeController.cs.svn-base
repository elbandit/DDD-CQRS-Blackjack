using System.Web.Mvc;
using KojackGames.Blackjack.Domain.DomainViews.Account;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Controllers.Account
{
    [Authorize]
    public class AccountHomeController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;        
        private readonly IQueryService _query_service;

        public AccountHomeController(IPlayerAuthenticator player_authenticator, 
                                     IQueryService query_service)
        {                        
            _player_authenticator = player_authenticator;
            _query_service = query_service;
        }

        [Authorize]
        public ActionResult Index()
        {
            var account_view =
                _query_service.query_for_single<AccountView>(
                    x => x.player_token == _player_authenticator.get_player_token());

            var account_information_view = new AccountInformationView();
            account_information_view.player_is_logged_in = true;
            account_information_view.player_name = account_view.name;

            var account_view_model = new AccountHomeView()
                                         {
                                             account_view = account_view,
                                             account_information_view = account_information_view
                                         };

            return View(account_view_model);
        }

    }
}
