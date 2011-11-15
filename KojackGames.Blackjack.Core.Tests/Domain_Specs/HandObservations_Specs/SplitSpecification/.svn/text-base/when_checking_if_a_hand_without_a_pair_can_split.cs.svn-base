using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.HandObservations_Specs.SplitSpecification
{
    [Subject(typeof(CanSplit))]
    public class when_checking_if_a_hand_without_a_pair_can_split
    {
        private Establish context = () =>
                                        {
                                            SUT = new CanSplit();
                                            players_hand = MockRepository.GenerateStub<IPlayersHand>();
                                            players_hand.Stub(x => x.is_made_up_of_two_matching_cards()).Return(false);
                                            players_hand.Stub(x => x.number_of_cards).Return(2);    
                                        };

        private Because of = () => result = SUT.is_satisfied_by(players_hand);

        It should_not_be_able_to_split = () =>
                                             {
                                                 Assert.That(result, Is.False);
                                             };

        private static CanSplit SUT;
        private static IPlayersHand players_hand;
        private static bool result;
    }
}