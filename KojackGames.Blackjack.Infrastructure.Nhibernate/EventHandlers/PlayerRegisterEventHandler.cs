using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.Membership.Events;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate.EventHandlers
{
    public class PlayerRegisterEventHandler : IDomainEventHandler<PlayerRegisteredEvent>
    {
        private readonly IReadRepository<MembershipEvent> _membership_events_repository;

        public PlayerRegisterEventHandler(IReadRepository<MembershipEvent> membership_events_repository)
        {
            _membership_events_repository = membership_events_repository;
        }

        public void handle(PlayerRegisteredEvent domain_event)
        {
            var membership_event = new MembershipEvent();
            membership_event.date_of_action = DateTime.Now;
            membership_event.action = MembershipEventActions.Registration;

            _membership_events_repository.add(membership_event);
        }
    }
}
