using System;
using System.Collections.Generic;

namespace KojackGames.Blackjack.Domain.DomainViews.BettingView
{
    public class BetOnBlackJackTableView
    {
        public Guid id { get; set; }        
        public Guid player_token { get; set; }
        public bool can_accept_bet { get; set; }
        public bool can_deal { get; set; }
        public decimal bet { get; set; }
        public decimal dollars_in_pot { get; set; }

        public IList<BetView> bets_placed { get; set; }

        public bool display
        {
            get { return can_accept_bet == true || can_deal == true; }
        }
    }
}
