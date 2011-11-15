using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using WatiN.Core;

namespace KojackGames.Blackjack.Acceptance.Tests.PageObjects
{
    public class AccountHomePage
    {
        public static string title
        {
            get { return WebBrowser.Current.TextField("Title").Value; }

            set { WebBrowser.Current.TextField("Title").Value = value; }
        }

        public static string welcome_note
        {
            get { return WebBrowser.Current.Div(Find.ByClass("welcomemessage")).Text; }
        }
    }
}
