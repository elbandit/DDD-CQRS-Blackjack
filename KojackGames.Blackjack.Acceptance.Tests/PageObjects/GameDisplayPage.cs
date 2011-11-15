using System;
using System.Collections.Generic;
using System.Linq;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using NUnit.Framework;
using WatiN.Core;

namespace KojackGames.Blackjack.Acceptance.Tests.PageObjects
{
    public class GameDisplayPage
    {
        public static bool has_double_button
        {
            get { return WebBrowser.Current.Button("btnDouble").Exists; }
        }
        
        public static string player_status_message
        {
            get { return player_status_message_for("A"); }            
        }

        public static string dealer_status_message
        {
            get { return WebBrowser.Current.Div(Find.ByClass("dealer_hand_status")).Text; } 
        }

        public static bool has_split_button
        {
            get { return WebBrowser.Current.Button("btnSplit").Exists; }
        }

        public static string game_status_message
        {
            get { return WebBrowser.Current.Div(Find.ByClass("game_status")).Text; } 
        }

        public static string pot_amount
        {
            get { return WebBrowser.Current.Span(Find.ByClass("pot_amount")).Text; } 
        }

        public static bool has_insurance_button
        {
            get { return WebBrowser.Current.Button("btnInsurance").Exists; }
        }

        public static bool does_not_have_insurance_button
        {
            get { return !WebBrowser.Current.Button("btnInsurance").Exists; }
        }

        public static void place_five_dollar_bet_on_hand_a()
        {
            WebBrowser.Current.Button("btnHandABet5").Click();
        }      

        public static IEnumerable<string> players_cards_for_hand(string hand_letter)
        {
            var elements = (IElementContainer)WebBrowser.Current.Div(Find.ByClass(String.Format("players_hand_{0}", hand_letter))).Element(Find.ByClass("cards"));
            
            return elements.ElementsWithTag("img").Cast<Image>().Select(e => e.Alt);                       
        }

        public static IEnumerable<string> dealers_cards()
        {
            var elements = (IElementContainer)WebBrowser.Current.Div(Find.ByClass("dealers_hand")).Element(Find.ByClass("cards"));

            return elements.ElementsWithTag("img").Cast<Image>().Select(e => e.Alt);              
        }

        public static void hit()
        {
            WebBrowser.Current.Button("btnHit").Click();
        }

        public static void stick()
        {
            WebBrowser.Current.Button("btnStick").Click();
        }

        public static void click_new_game_button()
        {
            WebBrowser.Current.Button("btnNewGame").Click();
        }

        public static void split()
        {
            WebBrowser.Current.Button("btnSplit").Click();
        }

        public static string player_status_message_for(string hand_letter)
        {
            return WebBrowser.Current.Div(Find.ByClass(String.Format("player_hand_status_{0}", hand_letter))).Text;     
        }

        public static void double_down()
        {
            WebBrowser.Current.Button("btnDouble").Click();            
        }

        public static void take_insurance()
        {
            WebBrowser.Current.Button("btnInsurance").Click();            
        }
    }
}
