using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BlackJackSpecification_Specs
{
    [Subject(typeof(HasBlackJack), "Has BlackJack Specification")]
    public class when_checking_for_blackjack_with_two_cards_that_make_blackjack
    {
        private Establish context = () =>
        {
            hand = MockRepository.GenerateStub<IHand>();
            hand.Stub(x => x.number_of_cards).Return(2);
            hand_scorer = MockRepository.GenerateStub<IHandScorer>();
            hand_scorer.Stub(x => x.calculate_score_for(hand)).Return(21);
            SUT = new HasBlackJack(hand_scorer);                        
        };

        private Because of = () => result = SUT.is_satisfied_by(hand);

        private It should_identify_the_hand_as_achieving_blackjack = () => Assert.That(result, Is.True);

        private static HasBlackJack SUT;
        private static IHand hand;        
        private static bool result;
        private static IHandScorer hand_scorer;
    }
}
