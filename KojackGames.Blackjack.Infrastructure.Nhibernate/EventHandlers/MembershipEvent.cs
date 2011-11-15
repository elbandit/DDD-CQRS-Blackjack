using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate.EventHandlers
{
    public class MembershipEvent
    {
        public int id { get; set; }
        public DateTime date_of_action { get; set; }
        public string action { get; set; }
    }
}
