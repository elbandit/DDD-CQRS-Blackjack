using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{    
    public class HasBust : IHasBustedSpecification
    {
        private readonly IHandScorer _hand_scorer;        
        private int blackjack_total = 21;

        public HasBust(IHandScorer hand_scorer)
        {
            _hand_scorer = hand_scorer;
        }

        public bool is_satisfied_by(IHand hand)
        {
            return _hand_scorer.calculate_score_for(hand) > blackjack_total;
        }
    }
}
