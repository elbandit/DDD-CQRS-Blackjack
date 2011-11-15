using System;
using System.Web.Mvc;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.UI.Web.Controllers.GamePlay;
using KojackGames.Blackjack.UI.Web.Models;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;
using Machine.Specifications;
using MvcContrib.TestHelper;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Controller_Specs.Bet
{
  
    [Subject(typeof(BetController))]
    public class when_betting_on_a_hand : with_a_BetController
    {
        private Establish context = () =>
        {
            player_token = Guid.NewGuid();
            bet_view = new BetView() { bet = 5m};
            bet_command = new BetCommand() {wager = 5m, player_token = player_token};

            player_authenticator.Stub(x => x.get_player_token()).Return(player_token);
            bet_command_mapper.Stub(x => x.map_from(bet_view, player_token)).Return(bet_command);
        };

        private Because of = () => result = SUT.Bet(bet_view);

        private It should_map_the_viewmodel_to_a_bet_command = () =>
        {
            bet_command_mapper.AssertWasCalled(x => x.map_from(bet_view, player_token));
        };

        private It should_ask_for_my_player_token = () =>
        {
            player_authenticator.AssertWasCalled(x => x.get_player_token());
        };

        private It should_send_a_bet_command_to_the_bus = () =>
        {
            command_bus.AssertWasCalled(x => x.send(bet_command));
        };

        private It should_return_a_redirect_to_display_the_bet_page = () =>
        {
            result.AssertActionRedirect().ToAction("Bet");
        };
                    
        private static BetView bet_view;
        private static BetCommand bet_command;
        private static Guid player_token;
        private static ActionResult result;
    }
}
