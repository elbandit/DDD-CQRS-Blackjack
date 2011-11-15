using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealerPlay
{
    [Subject(typeof(CanHitDealer), "can hit dealer")]
    public class when_checking_if_a_dealer_with_a_score_of_18_can_take_another_card
    {
        private Establish context = () =>
        {
            dealers_hand = MockRepository.GenerateStub<IDealersHand>();
            hand_scorer = MockRepository.GenerateStub<IHandScorer>();
            hand_scorer.Stub(x => x.calculate_score_for(dealers_hand)).Return(18);
            SUT = new CanHitDealer(hand_scorer);                        
        };

        private Because of = () => result = SUT.is_satisfied_by(dealers_hand);

        private It should_return_false = () => Assert.That(result, Is.False);
        

        private static CanHitDealer SUT;
        private static IDealersHand dealers_hand;
        private static bool result;
        private static IHandScorer hand_scorer;
    }
}
