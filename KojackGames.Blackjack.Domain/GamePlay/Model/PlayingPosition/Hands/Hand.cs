using System;
using System.Collections.Generic;
using System.Linq;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands
{    
    public abstract class Hand : IHand, IEntity
    {
        protected IBlackJackTable _blackjack_table;
        protected readonly IList<Card> _cards;        

        public Hand(IBlackJackTable black_jack_table)
        {            
            _blackjack_table = black_jack_table;            
            _cards = new List<Card>();            
            id = Guid.NewGuid();
            change_state_to(HandStatus.in_play);
        }

        protected Hand()
        {
        }

        public Guid id { get; private set;}

        public HandStatus status { get; private set; }

        public int number_aces
        {
            get { return _cards.Where(c => c.card_value == CardValue.Ace).Count(); }
        }

        public void change_state_to(HandStatus hand_status)
        {
            status = hand_status;
        }

        public bool has_status_of(HandStatus status)
        {
            return this.status.Equals(status);
        }

        public int version_id { get; private set; }

        public IEnumerable<Card> cards
        {
            get { return _cards; }
        }
 
        public int number_of_cards
        {
            get { return _cards.Count; }
        }

        public int score
        {
            get { return _cards.Sum(x => x.score); }
        }
        
        public int number_of_visible_aces
        {
            get { return _cards.Where(c => c.card_value == CardValue.Ace && c.is_visible()).Count(); }
        }

        public bool turn_ended()
        {
            return status.turn_ended;
        }

        public abstract void add(Card card);

        public bool is_made_up_of_two_matching_cards()
        {
            var contains_matching_pair = false;

            if (number_of_cards == 2)            
                contains_matching_pair = _cards[0].card_value == _cards[1].card_value;                            

            return contains_matching_pair;
        }
        
    }
}