using System;

namespace KojackGames.Blackjack.Domain.DomainViews.BettingView
{
    public class BetView
    {
        public Guid id { get; set; }
        public decimal wager { get; set; }

        public string wager_formatted
        {
            get { return string.Format("${0:0.00}", wager); }
        }
    }
}