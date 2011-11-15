using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class CanHitDealer : ICanHitDealerSpecification
    {
        private IHandScorer _hand_scorer;
        private int _dealers_hit_limit = 17;

        public CanHitDealer(IHandScorer hand_scorer)
        {
            this._hand_scorer = hand_scorer;
        }

        public bool is_satisfied_by(IDealersHand dealers_hand)
        {            
            return (_hand_scorer.calculate_score_for(dealers_hand) < _dealers_hit_limit) && dealers_hand.turn_ended() == false;
        }
    }
}
