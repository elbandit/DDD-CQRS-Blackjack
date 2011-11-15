using System;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BlackJackTable_Specs.Betting
{
    [Subject(typeof(BlackJackTable), "BlackJack table")]
    public class when_betting_on_a_table_without_a_free_position : on_a_blackjacktable                       
    {
        private Establish context = () =>
        {
            _chips_wagered = new Chips(5m);
            table_status.Stub(x => x.can_accept_bet).Return(true);
            playing_positions.Stub(x => x.has_free_position_for_bet()).Return(false);
        };
        
        Because of = () =>
            _resultingException = Catch.Exception(() => SUT.place_bet_on_free_position(_chips_wagered));

        It should_result_in_an_error = () =>
            _resultingException.ShouldBeOfType<IllegalMoveException>();

        private It should_cause_an_error = () => playing_positions.AssertWasCalled(x => x.has_free_position_for_bet());
        

        protected static Chips _chips_wagered;
        private static Exception _resultingException;
    }
}