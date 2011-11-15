using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealerPlay
{
    [Subject(typeof(PlayDealersHand), "players hand")]
    public class when_playing_the_dealers_hand_that_has_not_hit_threshold : with_the_PlayDealersHandAction
    {
        private Establish context = () =>
        {
            hands = MockRepository.GenerateStub<IPlayingPositions>();
            dealers_hand = MockRepository.GenerateStub<IDealersHand>();
            hands.Stub(x => x.dealers_hand).Return(dealers_hand);
            card_shoe = MockRepository.GenerateStub<ICardShoe>();

            can_hit_dealer_spec.Stub(x => x.is_satisfied_by(dealers_hand)).Return(true).Repeat.Once();
            can_hit_dealer_spec.Stub(x => x.is_satisfied_by(dealers_hand)).Return(false).Repeat.Once();

        };

        private Because of = () => SUT.draw_cards_for_dealer_in(hands, card_shoe);

        private It should_use_the_spec_to_make_sure_it_can_take_a_card_twice = () =>
        {
            can_hit_dealer_spec.AssertWasCalled(x => x.is_satisfied_by(hands.dealers_hand), o => o.Repeat.Twice());
        };

        private It should_take_one_card = () =>
        {
            card_shoe.AssertWasCalled(x => x.take_card(), o => o.Repeat.Once());
        };
       
        private It should_ask_the_hand_status_factory_to_determine_the_dealers_hand_status = () =>
        {
            hand_status_factory.AssertWasCalled(x => x.set_status_for(Arg<IHand>.Is.Anything));
        };

        private static IPlayingPositions hands;
        private static ICardShoe card_shoe;
        private static IDealersHand dealers_hand;
    }
}