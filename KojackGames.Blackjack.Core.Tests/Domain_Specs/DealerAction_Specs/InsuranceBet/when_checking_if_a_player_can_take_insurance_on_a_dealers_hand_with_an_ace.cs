using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.InsuranceBet
{
    [Subject(typeof(CanTakeInsurance))]
    public class when_checking_if_a_player_can_take_insurance_on_a_dealers_hand_with_an_ace
    {
        private Establish context = () =>
        {
            SUT = new CanTakeInsurance();
            dealers_hand = MockRepository.GenerateStub<IDealersHand>();            
            dealers_hand.Stub(x => x.number_of_visible_aces).Return(1);
        };

        private Because of = () => result = SUT.is_satisfied_by(dealers_hand);

        It should_be_able_to_take_insurance = () =>
        {
            Assert.That(result, Is.True);
        };

        private static CanTakeInsurance SUT;
        private static IDealersHand dealers_hand;
        private static bool result;
    }
}
