using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BlackJackSpecification_Specs
{
    [Subject(typeof(HasBlackJack), "Has BlackJack Specification")]
    public class when_checking_for_blackjack_with_two_cards_that_do_not_make_blackjack
    {
        private Establish context = () =>
        {
            hand = MockRepository.GenerateStub<IHand>();            
            hand_scorer = MockRepository.GenerateStub<IHandScorer>();
            hand_scorer.Stub(x => x.calculate_score_for(hand)).Return(7);
            SUT = new HasBlackJack(hand_scorer);                                    
        };

        private Because of = () => result = SUT.is_satisfied_by(hand);

        private It should_identify_the_hand_as_not_achieving_blackjack = () => Assert.That(result, Is.False);

        private static HasBlackJack SUT;
        private static IHand hand;
        private static bool result;
        private static IHandScorer hand_scorer;
    }
}
