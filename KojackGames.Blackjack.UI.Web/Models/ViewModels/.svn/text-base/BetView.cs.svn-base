using System.Collections.Generic;
using KojackGames.Blackjack.Domain.DomainViews.BettingView;

namespace KojackGames.Blackjack.UI.Web.Models.ViewModels
{
    public class BetView : IMasterView
    {                
        public decimal bet { get; set; }        
        public bool can_bet { get; set; }
        public bool can_deal { get; set; }

        public IEnumerable<Domain.DomainViews.BettingView.BetView> bets_placed { get; set; }

        public decimal dollars_in_pot { get; set; }        

        public string dollars_in_pot_formatted
        {
            get { return string.Format("${0:0.00}", dollars_in_pot); }
        }

        public AccountInformationView account_information_view { get; set; }        
    }
}