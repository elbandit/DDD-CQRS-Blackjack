using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace KojackGames.Blackjack.Infrastructure.Authentication
{
    public class AspFormsAuthentication : IFormsAuthentication 
    {
        public void SetAuthorisationToken(string token)
        {
            FormsAuthentication.SetAuthCookie(token, true);       
        }
       
        public void SignOut()
        {
            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();
        }
    }
}
