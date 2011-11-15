using System;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck
{    
    public class Card
    {
        private bool _hidden = true;

        private Card()
        {
            name = "hidden";
        }

        public Card(Suit suit, CardValue card_value) : this()
        {
            this.suit = suit;
            this.card_value = card_value;            
        }

        public Suit suit { get; private set; }
        public CardValue card_value { get; private set; }

        public int score 
        {
            get
            {
                if ((int)card_value > 10 )
                    return 10;
                else
                {
                    return (int) card_value;
                }
            }
        }

        public string name { get; set; }

        public void show()
        {
            _hidden = false;
            name = string.Format("{0} of {1}", card_value, suit);
        }

        public bool Equals(Card other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.suit, suit) && Equals(other.card_value, card_value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Card)) return false;
            return Equals((Card) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (suit.GetHashCode()*397) ^ card_value.GetHashCode();
            }
        }

        public override string ToString()
        {
            return name;
        }

        public bool is_visible()
        {
            return _hidden != true;
        }
    }
}