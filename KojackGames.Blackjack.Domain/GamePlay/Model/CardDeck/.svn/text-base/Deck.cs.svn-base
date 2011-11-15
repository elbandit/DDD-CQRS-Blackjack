using System;
using System.Collections.Generic;
using System.Linq;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck
{    
    public class Deck
    {
        private IList<DeckPosition> _cards_in_deck;
      
        public Deck()
        {            
        }

        public void initialize()
        {
            _cards_in_deck = new List<DeckPosition>();
            var cards = new List<Card>();
            int current = 0;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 1; x < 14; x++)
                {
                    var suit = (Suit)y;
                    var card_value = (CardValue)x;

                    var card = new Card(suit, card_value);

                    cards.Add(card);
                }
            }

            int position_in_deck = 1;

            foreach (var card in cards)
            {
                _cards_in_deck.Add(new DeckPosition() { card = card, position_in_pack = position_in_deck });

                position_in_deck++;
            }
        }

        public int no_of_cards_left_in_deck { get { return _cards_in_deck.Count(); } }        

        public void shuffle()
        {
            _cards_in_deck = _cards_in_deck.OrderBy(a => Guid.NewGuid()).ToList<DeckPosition>();
            
            int position_in_deck = 1;
            var shuffed_deck = new List<DeckPosition>();

            foreach (var deck_position in _cards_in_deck)
            {
                shuffed_deck.Add(new DeckPosition() { card = deck_position.card, position_in_pack = position_in_deck });

                position_in_deck++;
            }

            _cards_in_deck = shuffed_deck;
        }

        public Card take_card()
        {            
            _cards_in_deck.OrderBy(x => x.position_in_pack);

            var card = _cards_in_deck.First();

            _cards_in_deck.RemoveAt(0);

            return card.card;
        }
    }
}