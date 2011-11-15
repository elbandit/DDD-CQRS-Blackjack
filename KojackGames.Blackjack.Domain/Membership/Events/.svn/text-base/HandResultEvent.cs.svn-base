using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;

namespace KojackGames.Blackjack.Domain.Membership.Events
{
    public class HandResultEvent : IDomainEvent
    {        
        public HandResultEvent(string message)
        {
            this.message = message;
        }

        public string message { get; private set; }
    }
}
