using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BlackJackTable_Specs.Betting
{
    [Subject(typeof(BlackJackTable), "BlackJack table")]
    public class when_betting_on_a_table_with_a_free_position : on_a_blackjacktable
    {
        private Establish context = () =>
        {
            _chips_wagered = new Chips(5m);
            table_status.Stub(x => x.can_accept_bet).Return(true);
            playing_positions.Stub(x => x.has_free_position_for_bet()).Return(true);
            player.Stub(x => x.can_afford_to_bet(_chips_wagered)).Return(true);
        };

        private Because of = () => SUT.place_bet_on_free_position(_chips_wagered);

        private It should_check_the_table_status_to_ensure_it_can_take_a_bet = () => table_status.AssertWasCalled(x => x.can_accept_bet);

        private It should_ask_the_playing_position_if_there_are_any_free_hands_to_bet_on = () => playing_positions.AssertWasCalled(x => x.has_free_position_for_bet());

        private It should_ask_the_playing_position_to_add_a_new_hand = () => playing_positions.AssertWasCalled(x => x.place_bet_on_free_position(_chips_wagered, SUT));
        
        protected static Chips _chips_wagered;
    }
}
