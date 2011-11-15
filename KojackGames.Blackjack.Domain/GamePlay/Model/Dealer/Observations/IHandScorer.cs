using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{
    public interface IHandScorer
    {
        int calculate_score_for(IHand hand);
    }
}