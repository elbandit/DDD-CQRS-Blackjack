using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealCardsIn
{
    [Subject(typeof(Domain.GamePlay.Model.Dealer.Actions.DealCardsIn))]
    public class when_a_players_hand_meets_the_criteria_to_take_insurance_after_dealing : with_a_deal_in_cards_action
    {
        private Establish context = () =>
        {
            insurance_spec.Stub(x => x.is_satisfied_by(dealers_hand)).Return(true);
        };

        Because of = () => SUT.perform_on(positions, card_shoe, player);

        It should_check_the_players_hand_for_the_offer_for_insurance = () =>
        {
            insurance_spec.AssertWasCalled(x => x.is_satisfied_by(dealers_hand));
        };

        It should_mark_the_players_hand_as_being_able_to_take_insurance = () =>
        {
            players_hand.AssertWasCalled(x => x.mark_as_able_to_take_insurance());
        };
    }
}