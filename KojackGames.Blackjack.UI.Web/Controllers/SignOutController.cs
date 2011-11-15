using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KojackGames.Blackjack.Infrastructure.Authentication;

namespace KojackGames.Blackjack.UI.Web.Controllers
{
    public class SignOutController : Controller
    {
        private readonly IFormsAuthentication _forms_authentication;

        public SignOutController(IFormsAuthentication forms_authentication)
        {
            _forms_authentication = forms_authentication;
        }
        
        public ActionResult Index()
        {
            _forms_authentication.SignOut();

            this.FlashInfo("You have been signed out.");

            return RedirectToAction("LogOn", "AccountLogOn");
        }

    }
}
