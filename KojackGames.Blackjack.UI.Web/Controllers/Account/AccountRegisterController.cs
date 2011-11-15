using System;
using System.Web.Mvc;
using KojackGames.Blackjack.Domain.Membership.Commands;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Controllers.Account
{
    public class AccountRegisterController : Controller
    {
        private readonly ILocalAuthenticationService _authentication_service;
        private readonly ICommandBus _command_bus;
        private readonly IFormsAuthentication _forms_authentication;

        public AccountRegisterController(ILocalAuthenticationService authentication_service,
                                         ICommandBus command_bus,
                                         IFormsAuthentication forms_authentication)
        {
            _authentication_service = authentication_service;
            _command_bus = command_bus;
            _forms_authentication = forms_authentication;
        }


        public ActionResult Register()
        {
            var account_registration_form = new AccountRegisterFormView();
            account_registration_form.account_information_view = new AccountInformationView() { player_is_logged_in = false };

            return View(account_registration_form);
        }
       

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Register(AccountRegisterFormView account_registration_form_view)
        {
            account_registration_form_view.account_information_view = new AccountInformationView() { player_is_logged_in = false };
            User user;

            user = _authentication_service.RegisterUser(account_registration_form_view.email, account_registration_form_view.password);

            if (user.IsAuthenticated)
            {
                _forms_authentication.SetAuthorisationToken(user.AuthenticationToken);

                _command_bus.send(new RegisterPlayer()
                {
                    name = account_registration_form_view.name,
                    email = account_registration_form_view.email,
                    player_token = new Guid(user.AuthenticationToken)
                });

                this.FlashInfo("Your account has been created.");

                return RedirectToAction("Index", "AccountHome");
            }
            else
            {
                return View(account_registration_form_view);
            }                                                 
        }                
    }
}

