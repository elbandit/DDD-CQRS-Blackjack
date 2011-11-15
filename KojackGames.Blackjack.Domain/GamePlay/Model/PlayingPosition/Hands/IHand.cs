using System.Collections.Generic;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands
{
    public interface IHand
    {
        IEnumerable<Card> cards { get; }
        int number_of_cards { get; }
        int number_of_visible_aces { get; }
        int score { get; }
        int number_aces { get; }

        void change_state_to(HandStatus hand_status);        
        bool has_status_of(HandStatus status);

        bool turn_ended();

        void add(Card card);
        bool is_made_up_of_two_matching_cards();
    }
}