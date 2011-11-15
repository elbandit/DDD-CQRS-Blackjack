using System;
using System.Collections.Generic;

namespace KojackGames.Blackjack.Infrastructure.Domain
{
    public interface IRepository<Entity> where Entity : IEntity
    {
        Entity find_by(Guid id);
        IEnumerable<Entity> find_all();
        void save(Entity entity);
        Entity query_for_single(Func<Entity, bool> func);
        void remove(Entity entity);
    }
}