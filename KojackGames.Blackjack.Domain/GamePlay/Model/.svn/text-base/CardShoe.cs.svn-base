using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;

namespace KojackGames.Blackjack.Domain.GamePlay.Model
{
    public class CardShoe : ICardShoe
    {
        private readonly Deck _deck;

        private CardShoe()
        {
            
        }

        public CardShoe(Deck deck)
        {
            _deck = deck;
            _deck.initialize();
            _deck.shuffle();
        }

        public Card take_card()
        {
            return _deck.take_card();
        }
    }
}