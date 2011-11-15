using System;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using StructureMap;

namespace KojackGames.Blackjack.Infrastructure.Cqrs.Query
{
    public class StructureMapDomainEventHandlerRegistry : IDomainEventHandlerRegistry
    {        
        public IDomainEventHandler<TDomainEvent> find_handlers_for<TDomainEvent>(TDomainEvent domain_event) where TDomainEvent : IDomainEvent
        {            
            return ObjectFactory.TryGetInstance<IDomainEventHandler<TDomainEvent>>();
        }
    }
}