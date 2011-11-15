using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.HitHand
{
    public abstract class with_a_hit_hand_action
    {
        protected static Domain.GamePlay.Model.Dealer.Actions.HitHand SUT;
        protected static IAnnouceWinnerAction annouce_winner_action;
        protected static IHandStatusFactory hand_status_factory;
        protected static IPlayDealersHand player_dealers_hand;

        public with_a_hit_hand_action()
        {
            hand_status_factory = MockRepository.GenerateStub<IHandStatusFactory>();
            annouce_winner_action = MockRepository.GenerateStub<IAnnouceWinnerAction>();
            player_dealers_hand = MockRepository.GenerateStub<IPlayDealersHand>();

            SUT = new Domain.GamePlay.Model.Dealer.Actions.HitHand(hand_status_factory, player_dealers_hand, annouce_winner_action);
        }
    }
}