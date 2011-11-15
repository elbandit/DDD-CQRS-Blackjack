using System.Collections.Generic;
using System.Web.Mvc;
using KojackGames.Blackjack.Domain.DomainViews.Account;
using KojackGames.Blackjack.Domain.DomainViews.BettingView;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.UI.Web.Models;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;
using BetView = KojackGames.Blackjack.UI.Web.Models.ViewModels.BetView;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{
    [Authorize]
    public class BetController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;
        private readonly ICommandBus _command_bus;
        private readonly IQueryService _query_service;
        private readonly ICommandMapper<BetCommand, BetView> _bet_command_mapper;

        public BetController(IPlayerAuthenticator player_authenticator, 
                             ICommandBus command_bus,
                             IQueryService query_service,
                             ICommandMapper<BetCommand, BetView> bet_command_mapper)
        {
            _player_authenticator = player_authenticator;
            _command_bus = command_bus;
            _query_service = query_service;
            _bet_command_mapper = bet_command_mapper;
        }

        [Authorize]
        public ActionResult Bet()
        {
            var bet_on_table = _query_service.query_for_single<BetOnBlackJackTableView>(
                    x => x.player_token == _player_authenticator.get_player_token());

            var account_view = _query_service.query_for_single<AccountView>(
                    x => x.player_token == _player_authenticator.get_player_token());

            if (bet_on_table == null)
            {                
                var bet_on_game_form = new BetView();
                bet_on_game_form.account_information_view = new AccountInformationView() { player_is_logged_in = true, player_name = account_view .name};
                bet_on_game_form.bets_placed = new List<Domain.DomainViews.BettingView.BetView>();
                bet_on_game_form.can_bet = true;                
                bet_on_game_form.can_deal = false;
                bet_on_game_form.dollars_in_pot = account_view.dollars_in_pot;
                
                return View(bet_on_game_form);
            }
            else if (bet_on_table.display)
            {
                var bet_on_game_form = new BetView();
                bet_on_game_form.account_information_view = new AccountInformationView() { player_is_logged_in = true, player_name = account_view.name };
                bet_on_game_form.bets_placed = bet_on_table.bets_placed;                
                bet_on_game_form.can_bet = bet_on_table.can_accept_bet;
                bet_on_game_form.can_deal = bet_on_table.can_deal;
                bet_on_game_form.dollars_in_pot = bet_on_table.dollars_in_pot;

                return View(bet_on_game_form);
            }            
            else
            {
                return RedirectToAction("Display", "BlackJackTableGameView");
            }            
        }
      
        [HttpPost]
        [Authorize]
        public ActionResult Bet(BetView bet_view)
        {                        
            var bet_command = _bet_command_mapper.map_from(bet_view, _player_authenticator.get_player_token());

            try
            {
                _command_bus.send(bet_command);
            }
            catch (NotEnoughFundsException ex)
            {                
                this.FlashWarning(ex.Message);
            }            

            return RedirectToAction("Bet");
        }
    }
}
