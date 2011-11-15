using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealCardsIn
{
    [Subject(typeof(Domain.GamePlay.Model.Dealer.Actions.DealCardsIn), "Dealer")]
    public class when_dealing_in_the_hands_and_one_achieves_blackjack : with_a_deal_in_cards_action
    {
        private Establish context = () =>
        {
            positions.Stub(x => x.player_has_blackjack()).Return(true);
        };

        Because of = () => SUT.perform_on(positions, card_shoe, player);

        It should_check_if_a_hand_has_blackjack =
            () => positions.AssertWasCalled(x => x.player_has_blackjack());

        It should_determine_the_winning_hands =
            () => annouce_winner_action.AssertWasCalled(x => x.determine_winner_from(positions, player));
        
    }
}