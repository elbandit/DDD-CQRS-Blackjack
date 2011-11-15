using System;
using System.Collections.Generic;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects
{
    public class BlackJackTableRow
    {
        public Guid id { get; set; }
        public Guid player_token { get; set; }
        public bool finished { get; set; }        
        public int version { get; set; }
        public int state_id { get; set; }
        public bool can_accept_bet { get; set; }
        public bool can_deal { get; set; }
        public string state_name { get; set; }
        public IList<HandTableRow> hand_rows { get; set;}
        public IList<DeckRow> deck_rows { get; set; }

        public bool cards_dealt { get; set; }        
    }
}