using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player
{    
    public class PlayersHand : Hand, IPlayersHand
    {
        private readonly string _hand_letter;
        private bool _can_double_down;
        private bool _can_split;
        private bool _can_take_insurance;
        private bool _has_taken_insurance;

        public PlayersHand(Chips chips_wagered, IBlackJackTable black_jack_table, string hand_letter)
            : base(black_jack_table)
        {
            _hand_letter = hand_letter;
            wager = chips_wagered;
            is_active = false;    
        }

        protected PlayersHand() : base()
        {  }

        public string get_hand_letter()
        {
            return _hand_letter;
        }

        public bool has_taken_insurance()
        {
            return _has_taken_insurance;
        }

        public Chips wager { get; private set; }

        public void mark_as_taken_insurance()
        {
            _has_taken_insurance = true;
        }

        public void mark_as_able_to_double_down()
        {
            _can_double_down = true;
        }

        public void mark_as_able_to_split()
        {
            _can_split = true;
        }

        public void mark_as_able_to_take_insurance()
        {
            _can_take_insurance = true;
        }

        public IPlayersHand split_hand()
        {
            var split_hand = new PlayersHand(this.wager, this._blackjack_table, HandLetters.B.ToString());
            var card_to_move = this._cards[1];
            split_hand.add(card_to_move);
            this.remove(card_to_move);

            return split_hand;
        }

        public void remove_offer_to_double_down()
        {
            _can_double_down = false;
        }

        public void remove_offer_to_split()
        {
            _can_split = false;
        }

        public void remove_offer_to_take_insurance()
        {
            _can_take_insurance = false;
        }

        public void double_stake()
        {
            wager = wager.double_stake();
        }

        public void mark_as_active()
        {
            is_active = true;
        }

        public void mark_as_inactive()
        {
            is_active = false;
        }

        public bool is_active { get; private set; }

        private void remove(Card card)
        {
            this._cards.Remove(card);
        }

        public override void add(Card card)
        {
            card.show();
            base._cards.Add(card);                                    
        }        
    }  
}