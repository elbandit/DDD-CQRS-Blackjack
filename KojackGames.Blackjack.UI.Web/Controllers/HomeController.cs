using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var home_view = new HomeView();
            home_view.account_information_view = new AccountInformationView() {player_is_logged_in = false};

            return View(home_view);
        }

    }
}
