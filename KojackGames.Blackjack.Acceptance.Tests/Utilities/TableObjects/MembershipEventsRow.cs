using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects
{
    public class MembershipEventsRow
    {
        public int id { get; set; }
        public DateTime date_of_action { get; set; }
        public string action { get; set; }
    }
}
