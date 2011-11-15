using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations
{
    public class CanTakeInsurance : ICanTakeInsurance
    {
        public bool is_satisfied_by(IHand hand)
        {
            return hand.number_of_visible_aces > 0;
        }
    }
}