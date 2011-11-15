using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.StickHand
{
    public abstract class with_a_stick_action
    {
        protected static Domain.GamePlay.Model.Dealer.Actions.StickHand SUT;
        protected static IAnnouceWinnerAction annouce_winner_action;
        private IHandStatusFactory hand_status_factory;
        private IPlayDealersHand player_dealers_hand;

        public with_a_stick_action()
        {
            hand_status_factory = MockRepository.GenerateStub<IHandStatusFactory>();
            annouce_winner_action = MockRepository.GenerateStub<IAnnouceWinnerAction>();
            player_dealers_hand = MockRepository.GenerateStub<IPlayDealersHand>();

            SUT = new Domain.GamePlay.Model.Dealer.Actions.StickHand(hand_status_factory, player_dealers_hand, annouce_winner_action);
        }
    }
}