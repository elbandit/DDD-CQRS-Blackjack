using System;
using System.Collections.Generic;
using System.Linq;
using KojackGames.Blackjack.Infrastructure.Domain;
using NHibernate;
using NHibernate.Linq;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate
{
    public class NhRepository<T> : IRepository<T> where T : IEntity 
    {
        private readonly ISession _session;

        public NhRepository(ISession session)
        {
            _session = session;
        }

        public T find_by(Guid id)
        {
            return _session.Get<T>(id);
        }

        public IEnumerable<T> find_all()
        {
            return new List<T>();
        }

        public void save(T entity)
        {
            _session.SaveOrUpdate(entity);            
        }

        public T query_for_single(Func<T, bool> func)
        {
            return _session.Query<T>().Where(func).SingleOrDefault();            
        }

        public void remove(T entity)
        {
            _session.Delete(entity);
        }
    }
}
