using System;

namespace KojackGames.Blackjack.UI.Web.Models.ViewModels
{
    public class AccountInformationView : IMasterView 
    {
        public bool player_is_logged_in { get; set; }
        public string player_name { get; set; }

        public AccountInformationView account_information_view { get; set; }        
    }
}