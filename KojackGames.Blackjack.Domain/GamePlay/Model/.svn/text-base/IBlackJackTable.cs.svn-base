using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model
{
    public interface IBlackJackTable
    {
        IPlayer player { get; }
        Guid id { get; }
        int version_id { get; }
        void place_bet_on_free_position(Chips chips_wagered);
        void perform_action_with(IDealerAction dealer_action);
        bool has_finished();
        bool Equals(BlackJackTable other);
        bool Equals(object obj);
        int GetHashCode();
    }
}