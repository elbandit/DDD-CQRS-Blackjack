using System.Web.Mvc;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{
    public class InsuranceController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;
        private readonly ICommandBus _command_bus;

        public InsuranceController(IPlayerAuthenticator player_authenticator, ICommandBus command_bus)
        {
            _player_authenticator = player_authenticator;
            _command_bus = command_bus;
        }

        [HttpPost]
        public ActionResult Insurance()
        {
            var hit_hand_command = new TakeInsuranceCommand();
            hit_hand_command.player_id = _player_authenticator.get_player_token();

            _command_bus.send(hit_hand_command);

            return RedirectToAction("Display", "BlackJackTableGameView");
        }

    }
}
