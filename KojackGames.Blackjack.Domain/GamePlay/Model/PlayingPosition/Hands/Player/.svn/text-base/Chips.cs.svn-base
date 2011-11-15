using System;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player
{    
    public class Chips
    {        
        public Chips(decimal amount)
        {
            value = amount;
        }

        private Chips()
        {
                
        }

        public decimal value { get; private set; }

        public Chips halved()
        {
            return new Chips(value/2);
        }

        public override string ToString()
        {                         
            return string.Format("${0:0.00}", value);
        }

        public Chips mulitple_by_odds_of(int you_receive_back, int for_every_dollar_bet)
        {
            var result = (value/for_every_dollar_bet)*you_receive_back;

            return new Chips(result);
        }

        public Chips add(Chips wager)
        {
            return new Chips(wager.value + value);
        }

        public Chips double_stake()
        {
            return new Chips(value * 2);
        }

        public bool contains_chips()
        {
            return this.value > 0;
        }
    }
}