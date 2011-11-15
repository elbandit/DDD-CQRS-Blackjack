using System.Web.Mvc;
using KojackGames.Blackjack.Domain.DomainViews.Account;
using KojackGames.Blackjack.Domain.DomainViews.InPlayView;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{
    [Authorize]
    public class BlackJackTableGameViewController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;        
        private readonly IQueryService _query_service;

        public BlackJackTableGameViewController(IPlayerAuthenticator player_authenticator, 
                                                IQueryService query_service)
        {
            _player_authenticator = player_authenticator;                        
            _query_service = query_service;
        }

        public ActionResult display()
        {
            var game_summary =
                _query_service.query_for_single<BlackJackTableView>(
                    x => x.player_token == _player_authenticator.get_player_token());

            var account_view = _query_service.query_for_single<AccountView>(
                    x => x.player_token == _player_authenticator.get_player_token());

            var game_play_view = new GamePlayView();

            game_play_view.table = game_summary;
            game_play_view.account_information_view = new AccountInformationView() { player_is_logged_in = true, player_name = account_view.name };

            if (game_summary == null)
                return RedirectToAction("Bet", "Bet");
            else
            {
                if (TempData.ContainsKey("Message"))
                    game_summary.game_message = TempData["Message"].ToString();

                return View(game_play_view);
            }
        }
    }
}