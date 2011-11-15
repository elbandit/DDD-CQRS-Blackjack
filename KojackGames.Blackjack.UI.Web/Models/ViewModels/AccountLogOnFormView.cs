using System;

namespace KojackGames.Blackjack.UI.Web.Models.ViewModels
{
    public class AccountLogOnFormView : IMasterView 
    {
        public string email { get; set; }
        public string password { get; set; }

        public AccountInformationView account_information_view { get; set; }        
    }
}