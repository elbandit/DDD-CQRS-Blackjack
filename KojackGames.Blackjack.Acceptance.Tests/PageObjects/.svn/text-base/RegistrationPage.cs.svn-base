using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;

namespace KojackGames.Blackjack.Acceptance.Tests.PageObjects
{
    public class RegistrationPage
    {
        public static void register()
        {
            WebBrowser.Current.Button("btnRegister").Click();
        }

        public static string set_password_to
        {
            set { WebBrowser.Current.TextField("password").Value = value; }
        }

        public static string set_email_to
        {
            set { WebBrowser.Current.TextField("email").Value = value; }
        }

        public static string set_name_to
        {
            set { WebBrowser.Current.TextField("name").Value = value; }
        }
    }
}
