using System;
using System.Collections.Generic;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects
{
    public class HandTableRow
    {
        public Guid id { get; set; }
        public BlackJackTableRow blackjacktable { get; set; }
        public string discriminator { get; set; }
        public decimal bet { get; set; }
        public int version { get; set; }
        public bool is_active { get; set; }
        public int state_id { get; set; }
        public bool turn_ended { get; set; }
        public string state_name { get; set; }
        public string hand_letter { get; set; }
        public IList<CardInHandRow> card_in_hand_rows { get; set; }
    }
}