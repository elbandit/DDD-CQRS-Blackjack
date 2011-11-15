using System;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects
{
    public class DeckRow
    {
        public Guid blackjacktable_id { get; set; }
        public int suit { get; set; }
        public int card_value { get; set; }
        public int position_in_pack { get; set; }
    }
}