using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{
    public class CanSplit : ICanSplit
    {
        public bool is_satisfied_by(IHand hand)
        {
            if (hand.number_of_cards == 2)
            {
                if (hand.is_made_up_of_two_matching_cards())
                {
                    return true;
                }
            }

            return false;
        }
    }
}