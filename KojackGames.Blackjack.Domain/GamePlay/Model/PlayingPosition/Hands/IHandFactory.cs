using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands
{
    public interface IHandFactory
    {
        Hand create_players_hand_with(Chips chips_wagered, BlackJackTable black_jack_table, string hand_letter);
        Hand create_dealers_hand_for(BlackJackTable black_jack_table);
    }
}