using System.Web.Mvc;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.Membership.Events;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{
    public class DoubleDownController : Controller
    {
         private readonly IPlayerAuthenticator _player_authenticator;
        private readonly ICommandBus _command_bus;

        public DoubleDownController(IPlayerAuthenticator player_authenticator, ICommandBus command_bus)
        {
            _player_authenticator = player_authenticator;
            _command_bus = command_bus;
        }

        [HttpPost]
        public ActionResult DoubleDown()
        {
            var split_hand_command = new DoubleDownCommand();
            split_hand_command.player_id = _player_authenticator.get_player_token();

            DomainEvents.register_temp_event_handler<HandResultEvent>(e => this.FlashInfo(e.message));

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
