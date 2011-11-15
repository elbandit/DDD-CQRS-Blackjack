using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DetermineWinner
{
    public abstract class with_AnnouceWinnerAction
    {
        public static IHandScorer hand_scorer;
        public static AnnouceWinnerAction SUT;

        public with_AnnouceWinnerAction()
        {
            hand_scorer = MockRepository.GenerateStub<IHandScorer>();
            SUT = new AnnouceWinnerAction(hand_scorer);
        }
    }
}