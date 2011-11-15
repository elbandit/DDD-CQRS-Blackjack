using System;
using System.Collections.Generic;

namespace KojackGames.Blackjack.Infrastructure.Cqrs.Query
{
    public interface IQueryService
    {        
        T query_for_single<T>(Func<T, bool> query);             
    }
}
