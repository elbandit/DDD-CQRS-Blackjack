using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BustSpecification_Specs
{
    [Subject(typeof(HasBust), "Has Bust Specification")]
    public class when_checking_that_a_hand_under_21_has_bust
    {
        private Establish context = () =>
        {
            hand = MockRepository.GenerateStub<IHand>();            
            hand_scorer = MockRepository.GenerateStub<IHandScorer>();
            hand_scorer.Stub(x => x.calculate_score_for(hand)).Return(17);
            SUT = new HasBust(hand_scorer);                                              
        };

        private Because of = () => result = SUT.is_satisfied_by(hand);

        private It should_identify_the_hand_has_not_bust = () => Assert.That(result, Is.False);

        private static HasBust SUT;
        private static IHand hand;                
        private static bool result;
        private static IHandScorer hand_scorer;
    }
}
