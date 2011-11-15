using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands
{    
    public class HandFactory : IHandFactory
    {
        public Hand create_players_hand_with(Chips chips_wagered, BlackJackTable black_jack_table, string hand_letter)
        {
            var players_hand = new PlayersHand(chips_wagered, black_jack_table, hand_letter);
            players_hand.mark_as_active();

            return players_hand;
        }

        public Hand create_dealers_hand_for(BlackJackTable black_jack_table)
        {
            return new DealersHand(black_jack_table);
        }
    }
}