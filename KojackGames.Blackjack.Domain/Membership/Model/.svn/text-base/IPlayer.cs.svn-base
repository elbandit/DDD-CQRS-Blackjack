using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;

namespace KojackGames.Blackjack.Domain.Membership.Model
{
    public interface IPlayer
    {
        decimal dollars_in_pot { get; set; }
        string name { get; set; }        
        Guid id { get; }
        bool can_afford_to_bet(Chips wager);
        void decrease_pot_by(Chips wager);
        void increase_pot_by(Chips wager);
    }
}