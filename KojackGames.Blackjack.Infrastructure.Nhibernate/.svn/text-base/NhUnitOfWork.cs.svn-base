using NHibernate;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate
{
    public class NhUnitOfWork : IUnitOfWork
    {
        private readonly ISession _session;

        public NhUnitOfWork(ISession session)
        {
            _session = session;
        }

        public void Dispose()
        {
            using (var trans = _session.BeginTransaction())
            {
                trans.Commit();
            }
        }
    }
}