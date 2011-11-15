using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Infrastructure.Cqrs.Query
{
    public interface IDomainEventHandlerRegistry
    {        
        IDomainEventHandler<TDomainEvent> find_handlers_for<TDomainEvent>(TDomainEvent domain_event) where TDomainEvent : IDomainEvent;
    }
}
