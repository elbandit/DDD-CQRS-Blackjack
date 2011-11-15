using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Infrastructure.Authentication
{
    public interface IFormsAuthentication
    {
       void SetAuthorisationToken(string token);       
       void SignOut();
    }                
}
