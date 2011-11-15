using System.Web.Mvc;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{     
    public class SplitController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;
        private readonly ICommandBus _command_bus;

        public SplitController(IPlayerAuthenticator player_authenticator, ICommandBus command_bus)
        {
            _player_authenticator = player_authenticator;
            _command_bus = command_bus;
        }

        [HttpPost]
        public ActionResult Split()
        {
            var split_hand_command = new SplitHandCommand();
            split_hand_command.player_id = _player_authenticator.get_player_token();

            try
            {
                _command_bus.send(split_hand_command);
            }
            catch (IllegalMoveException ex)
            {
                TempData["Message"] = ex.Message;
            }            

            return RedirectToAction("Display", "BlackJackTableGameView");
        }

    }
}
