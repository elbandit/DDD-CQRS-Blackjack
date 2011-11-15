using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{    
    public class HasBlackJack : IHasBlackjackSpecification        
    {
        private int blackjack_total = 21;        
        private readonly IHandScorer _hand_scorer;

        public HasBlackJack(IHandScorer hand_scorer)
        {
            _hand_scorer = hand_scorer;
        }

        public bool is_satisfied_by(IHand hand)
        {
            bool has_blackjack = false;

            if (hand.number_of_cards == 2)
            {
                has_blackjack = (_hand_scorer.calculate_score_for(hand) == blackjack_total);                
            }

            return has_blackjack;
        }
    }
}
