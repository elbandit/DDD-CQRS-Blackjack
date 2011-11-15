using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.HandObservations_Specs.DoubleDownSpecification
{
    [Subject(typeof(CanDoubleDown))]
    public class when_checking_if_a_hand_with_3_cards_can_double_down
    {
        private Establish context = () =>
                                        {
                                            SUT = new CanDoubleDown();
                                            players_hand = MockRepository.GenerateStub<IPlayersHand>();
                                            players_hand.Stub(x => x.score).Return(12);
                                            players_hand.Stub(x => x.number_of_cards).Return(3);
                                        };

        private Because of = () => result = SUT.is_satisfied_by(players_hand);

        It should_not_be_able_to_double_down = () =>
                                                   {
                                                       Assert.That(result, Is.False);
                                                   };

        private static CanDoubleDown SUT;
        private static IPlayersHand players_hand;
        private static bool result;
    }
}