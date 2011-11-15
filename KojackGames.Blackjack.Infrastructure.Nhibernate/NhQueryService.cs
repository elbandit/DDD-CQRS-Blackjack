using System;
using System.Linq;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using NHibernate.Linq;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate
{
    public class NhQueryService : IQueryService
    {
        public T query_for_single<T>(Func<T, bool> query)
        {
            using (var session = SessionFactory.GetNewSession())
            {
                return session.Query<T>().Where(query).FirstOrDefault();
            } 
        }        
    }
}
