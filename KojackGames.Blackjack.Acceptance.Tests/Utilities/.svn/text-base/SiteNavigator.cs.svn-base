using System;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities
{
    public static class SiteNavigator
    {    
        private static void go_to(string relativeUrl)
        {
            WebBrowser.Current.GoTo(string.Format("http://localhost:{0}/{1}", WebBrowser.Port,relativeUrl));
        }
        
        public static void go_to_bet_page()
        {
            go_to("bet/bet");
        }

        public static void go_to_login_page_and_pass(Guid player_token)
        {
            go_to(string.Format("LogInPlayer/SetLoginTo?player_id={0}", player_token.ToString()));
        }

        public static void go_to_registration_page()
        {
            go_to("AccountRegister/Register");
        }

        public static void go_to_account_home()
        {
            go_to("AccountHome/Index");
        }

        public static void go_to_login()
        {
            go_to("AccountLogon/LogOn");
        }

        public static void sign_out()
        {
            go_to("SignOut/Index");
        }
    }
}
