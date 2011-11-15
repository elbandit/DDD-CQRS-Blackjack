using KojackGames.Blackjack.Domain.DomainViews.Account;

namespace KojackGames.Blackjack.UI.Web.Models.ViewModels
{
    public class AccountHomeView : IMasterView 
    {
        public AccountView account_view { get; set; }
        public AccountInformationView account_information_view { get; set; }        
    }
}