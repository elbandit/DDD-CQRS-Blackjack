using System;

namespace KojackGames.Blackjack.Infrastructure.Authentication
{
    public interface IPlayerAuthenticator
    {        
        Guid get_player_token();               
    }
}