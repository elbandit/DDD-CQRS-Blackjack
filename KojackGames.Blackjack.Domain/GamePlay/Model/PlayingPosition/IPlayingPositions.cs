using System.Collections;
using System.Collections.Generic;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition
{
    public interface IPlayingPositions
    {                                                                                                           
        void place_bet_on_free_position(Chips chips_wagered, BlackJackTable black_jack_table);               
        void create_dealers_hand_for(BlackJackTable black_jack_table);

        IEnumerable<IHand> all_hands { get; }
        IDealersHand dealers_hand { get; }
        IPlayersHand players_active_hand { get; }
        IEnumerable<IPlayersHand> players_hands();
        
        bool player_has_blackjack();
        bool has_free_position_for_bet();
        bool have_cards_been_dealt();
        void mark_cards_as_dealt();
        bool player_has_finished();
        void split_players_hand();        
        void clear_all_first_hand_decision_offers();
        void update_active_hand();
    }
}