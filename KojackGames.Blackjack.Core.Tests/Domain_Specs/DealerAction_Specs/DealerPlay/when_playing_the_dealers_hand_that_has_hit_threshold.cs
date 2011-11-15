using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealerPlay
{
    [Subject(typeof(PlayDealersHand), "players hand")]
    public class when_playing_the_dealers_hand_that_has_hit_threshold : with_the_PlayDealersHandAction
    {
        private Establish context = () =>
        {
            hands = MockRepository.GenerateStub<IPlayingPositions>();            
            dealers_hand = MockRepository.GenerateStub<IDealersHand>();
            hands.Stub(x => x.dealers_hand).Return(dealers_hand);
            card_shoe = MockRepository.GenerateStub<ICardShoe>();

            can_hit_dealer_spec.Stub(x => x.is_satisfied_by(dealers_hand)).Return(false);
            
        };

        private Because of = () => SUT.draw_cards_for_dealer_in(hands, card_shoe);

        private It should_use_the_spec_to_make_sure_it_can_take_a_card = () =>
        {
            can_hit_dealer_spec.AssertWasCalled(x => x.is_satisfied_by(hands.dealers_hand));
        };

        private It should_not_take_a_card = () =>
        {
            card_shoe.AssertWasNotCalled(x => x.take_card());
        };
                
        private static IPlayingPositions hands;
        private static ICardShoe card_shoe;
        private static IDealersHand dealers_hand;
    }
}
