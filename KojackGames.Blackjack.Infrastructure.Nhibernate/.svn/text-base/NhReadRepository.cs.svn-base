using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using NHibernate;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate
{
    public class NhReadRepository<T> : IReadRepository<T>
    {
        private readonly ISession _session;

        public NhReadRepository(ISession session)
        {
            _session = session;
        }

        public void add(T @event)
        {
            _session.Save(@event);      
        }
    }
}