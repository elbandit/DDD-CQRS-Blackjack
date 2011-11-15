using System;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using NUnit.Framework;
using WatiN.Core;

namespace KojackGames.Blackjack.Acceptance.Tests.PageObjects
{
    public class BetOnHandPage
    {                 
        public static string flash_message
        {
            get { return WebBrowser.Current.Div(Find.ById("flash")).Text; } 
        }

        public static void bet_5_dollars()
        {
            WebBrowser.Current.Button("btnBet_5").Click();
        }

        public static void deal()
        {
            WebBrowser.Current.Button("btnDeal").Click();
        }

        public static bool has_deal_button
        {
            get { return WebBrowser.Current.Button("btnDeal").Exists; }
        }

        public static bool has_bet_button
        {
            get { return WebBrowser.Current.Button("btnBet_5").Exists; }
        }

        public static bool has_hit_button
        {
            get { return WebBrowser.Current.Button("btnHit").Exists; }
        }

        public static bool has_stick_button
        {
            get { return WebBrowser.Current.Button("btnStick").Exists; }
        }        
    }
}
