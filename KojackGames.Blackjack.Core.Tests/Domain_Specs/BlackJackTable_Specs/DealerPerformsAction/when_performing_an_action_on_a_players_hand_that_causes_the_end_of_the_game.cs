using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BlackJackTable_Specs.DealerPerformsAction
{
    [Subject(typeof(BlackJackTable), "BlackJack table")]
    public class when_performing_an_action_on_a_players_hand_that_causes_the_end_of_the_game : on_a_blackjacktable
    {
        private Establish context = () =>
        {
            dealer_action = MockRepository.GenerateStub<IDealerAction>();            

            playing_positions.Stub(x => x.player_has_finished()).Return(true);          
        };

        private Because of = () => SUT.perform_action_with(dealer_action);

        private It should_check_if_all_hands_had_played = () => playing_positions.AssertWasCalled(x => x.player_has_finished());
        
        private static IDealerAction dealer_action;     
    }
}