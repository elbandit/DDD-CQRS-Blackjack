using System.Web.Mvc;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Controllers.Account
{
    public class AccountLogOnController : Controller
    {
        private readonly ILocalAuthenticationService _authentication_service;
        private readonly IFormsAuthentication _forms_authentication;

        public AccountLogOnController(ILocalAuthenticationService authentication_service,
                                      IFormsAuthentication forms_authentication)
        {
            _authentication_service = authentication_service;
            _forms_authentication = forms_authentication;
        }

        public ActionResult LogOn()
        {
            AccountLogOnFormView accountLogonFormView = new AccountLogOnFormView();
            accountLogonFormView.account_information_view = new AccountInformationView() {player_is_logged_in = false};

            return View(accountLogonFormView);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LogOn(AccountLogOnFormView accountLogonFormView)
        {
            accountLogonFormView.account_information_view = new AccountInformationView() { player_is_logged_in = false };
            User user = _authentication_service.Login(accountLogonFormView.email, accountLogonFormView.password);

            if (user.IsAuthenticated)
            {
                _forms_authentication.SetAuthorisationToken(user.AuthenticationToken);

                return RedirectToAction("Index", "AccountHome");
            }
            else
            {
                //AccountView accountView = InitializeAccountViewWithIssue(true, "Sorry we could not log you in. Please try again.");
                //accountView.CallBackSettings.ReturnUrl =
                //                          GetReturnActionFrom(returnUrl).ToString();                

                return View(accountLogonFormView);
            }
        }              
    }
}
