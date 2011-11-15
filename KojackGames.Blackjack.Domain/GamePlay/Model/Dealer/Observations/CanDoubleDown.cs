using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{
    public class CanDoubleDown : ICanDoubleDown
    {
        public bool is_satisfied_by(IHand hand)
        {
            if (hand.number_of_cards == 2)
            {
                if (hand.score > 7 && hand.score < 11 || hand.score == 11 && hand.number_of_visible_aces == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}