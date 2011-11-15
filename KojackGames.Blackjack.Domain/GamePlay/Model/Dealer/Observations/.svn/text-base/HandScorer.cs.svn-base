using System.Linq;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{
    public class HandScorer : IHandScorer
    {        
        private int blackjack_total = 21;
        private int upper_ace_value_addition = 10; 
                
        public int calculate_score_for(IHand hand)
        {
            var card_score_total = hand.cards.Sum(x => x.score);

            if (card_score_total < blackjack_total && hand.number_aces > 0)
            {
                if (!(card_score_total + upper_ace_value_addition > blackjack_total))
                {
                    card_score_total += upper_ace_value_addition;
                }                                    
            }

            return card_score_total;
        }
    }
}
