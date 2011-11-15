using System;

namespace KojackGames.Blackjack.Infrastructure.Domain
{    
    public abstract class DomainBase<TEntityType> where TEntityType : IEntity
    {
        public Guid id
        {
            get; protected set;
        }

        public int version_id { get; private set; }

        public bool Equals(TEntityType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.id.Equals(id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TEntityType)) return false;
            return Equals((TEntityType)obj);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
