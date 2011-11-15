using System.Linq;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer
{    
    public class DealersHand : Hand, IDealersHand
    {                        
        public DealersHand(IBlackJackTable black_jack_table)
            : base(black_jack_table)
        {     }

        protected DealersHand() : base()
        {     }

        public void show_card_in_hole()
        {
            foreach(var card in _cards)            
                card.show();            
        }

        public override void add(Card card)
        {            
            if (_cards.Count() != 1)
                card.show();

            base._cards.Add(card);         
        }      
    }
}
