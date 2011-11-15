using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;

namespace KojackGames.Blackjack.Infrastructure.Domain
{    
    // static gateway..
    public static class DomainEvents
    {
        private static IDomainEventHandlerRegistry _command_handler_registry;
       
        public static void set_registry(IDomainEventHandlerRegistry command_handler_registry)
        {
            _command_handler_registry = command_handler_registry;
        }
      
        public static void register_temp_event_handler<T>(Action<T> callback)
        {
            if (HttpContext.Current.Items["event_handlers"] == null)
                HttpContext.Current.Items["event_handlers"] = new List<Delegate>();

            ((List<Delegate>) HttpContext.Current.Items["event_handlers"]).Add(callback);
        }

        public static void raise<T>(T domain_event) where T : IDomainEvent
        {
            if (_command_handler_registry.find_handlers_for(domain_event) != null)
                _command_handler_registry.find_handlers_for(domain_event).handle(domain_event);

            if (HttpContext.Current.Items["event_handlers"] != null)
            {
                foreach (var action in ((List<Delegate>)HttpContext.Current.Items["event_handlers"]))
                      if (action is Action<T>)
                          ((Action<T>)action)(domain_event);
            }

        } 
    }
}
