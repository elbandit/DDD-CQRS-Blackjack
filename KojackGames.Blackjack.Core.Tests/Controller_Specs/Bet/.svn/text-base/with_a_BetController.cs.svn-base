using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.UI.Web.Controllers;
using KojackGames.Blackjack.UI.Web.Controllers.GamePlay;
using KojackGames.Blackjack.UI.Web.Models;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Controller_Specs.Bet
{
    public abstract class with_a_BetController
    {
        protected static IPlayerAuthenticator player_authenticator;
        protected static BetController SUT;
        protected static ICommandBus command_bus;        
        protected static ICommandMapper<BetCommand, BetView> bet_command_mapper;
        protected static IQueryService query_service;

        public with_a_BetController()
        {
            player_authenticator = MockRepository.GenerateStub<IPlayerAuthenticator>();
            command_bus = MockRepository.GenerateStub<ICommandBus>();
            query_service = MockRepository.GenerateStub<IQueryService>();
            bet_command_mapper = MockRepository.GenerateStub<ICommandMapper<BetCommand, BetView>>();

            SUT = new BetController(player_authenticator, command_bus, query_service, bet_command_mapper);
        }
    }
}
