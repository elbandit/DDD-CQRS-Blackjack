using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KojackGames.Blackjack.Domain.DomainViews.Account;
using KojackGames.Blackjack.Domain.Membership.Commands;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Controllers
{
    public class CashInController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;
        private readonly ICommandBus _command_bus;
        private readonly IQueryService _query_service;

        public CashInController(IPlayerAuthenticator player_authenticator, 
                                ICommandBus command_bus,
                                IQueryService query_service)
        {
            _player_authenticator = player_authenticator;
            _command_bus = command_bus;
            _query_service = query_service;
        }

        [Authorize]
        public ActionResult CashIn()
        {
            var account_view =
                _query_service.query_for_single<AccountView>(
                    x => x.player_token == _player_authenticator.get_player_token());

            var account_information_view = new AccountInformationView();
            account_information_view.player_is_logged_in = true;
            account_information_view.player_name = account_view.name;

            var cash_in_view = new CashInView() {account_information_view = account_information_view};

            return View(cash_in_view);
        }

        [HttpPost]
        [Authorize]
        public ActionResult CashIn(CashInView cash_in_view)
        {
            this.FlashInfo("You have cashed in $30.00.");

            var cash_in = new CashInCommand
                              {
                                  player_token = _player_authenticator.get_player_token(),
                                  amount = 30
                              };

            _command_bus.send(cash_in);

            return RedirectToAction("Index", "AccountHome");
        }

    }
}
