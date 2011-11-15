using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;

namespace KojackGames.Blackjack.Domain.GamePlay.Model
{
    public interface ICardShoe
    {        
        Card take_card();
    }
}