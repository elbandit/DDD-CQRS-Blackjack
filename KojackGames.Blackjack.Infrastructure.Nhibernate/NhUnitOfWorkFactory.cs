using NHibernate;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate
{
    public class NhUnitOfWorkFactory : IUnitOfWorkFactory 
    {
        private readonly ISession _session;

        public NhUnitOfWorkFactory(ISession session)
        {
            _session = session;
        }

        public IUnitOfWork create()
        {
            return new NhUnitOfWork(_session);
        }
    }
}
