using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Infrastructure.Cqrs.Query
{
    public interface IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        void handle(TDomainEvent domain_event);
    }
}
