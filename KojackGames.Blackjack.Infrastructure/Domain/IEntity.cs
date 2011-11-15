using System;

namespace KojackGames.Blackjack.Infrastructure.Domain
{
    public interface IEntity
    {
        Guid id { get; }
        int version_id { get; }
    }
}
