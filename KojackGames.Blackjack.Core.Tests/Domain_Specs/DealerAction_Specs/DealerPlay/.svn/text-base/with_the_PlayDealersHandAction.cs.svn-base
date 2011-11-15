using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealerPlay
{
    public abstract class with_the_PlayDealersHandAction
    {
        public static ICanHitDealerSpecification can_hit_dealer_spec;
        public static IHandStatusFactory hand_status_factory;
        public static PlayDealersHand SUT;

        public with_the_PlayDealersHandAction()
        {
            can_hit_dealer_spec = MockRepository.GenerateStub<ICanHitDealerSpecification>();            
            hand_status_factory = MockRepository.GenerateStub<IHandStatusFactory>();

            SUT = new PlayDealersHand(can_hit_dealer_spec, hand_status_factory);
        }
    }
}