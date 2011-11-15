using System;
using System.Web;

namespace KojackGames.Blackjack.Infrastructure.Authentication
{
    public class HttpPlayerAuthenticator : IPlayerAuthenticator
    {
        public Guid get_player_token()
        {
            return new Guid(HttpContext.Current.User.Identity.Name);
        }
    }
}