using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.SoftBlackJackSpecification_Specs
{
    [Subject(typeof(HasSoftBlackJack), "Has Soft BlackJack Specification")]
    public class when_checking_for_soft_blackjack_with_a_hand_that_contains_two_aces
    {
        private Establish context = () =>
        {
            hand = MockRepository.GenerateStub<IHand>();
            hand.Stub(x => x.number_of_cards).Return(3);
            hand_scorer = MockRepository.GenerateStub<IHandScorer>();
            hand_scorer.Stub(x => x.calculate_score_for(hand)).Return(21);
            SUT = new HasSoftBlackJack(hand_scorer);                              
        };

        private Because of = () => result = SUT.is_satisfied_by(hand);

        private It should_identify_the_hand_as_achieving_blackjack = () => Assert.That(result, Is.True);

        private static HasSoftBlackJack SUT;
        private static IHand hand;
        private static bool result;
        private static IHandScorer hand_scorer;
    }
}
