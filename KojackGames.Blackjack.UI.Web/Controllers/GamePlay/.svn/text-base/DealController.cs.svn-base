using System.Web.Mvc;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.Membership.Events;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{
    [Authorize]
    public class DealController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;
        private readonly ICommandBus _command_bus;

        public DealController(IPlayerAuthenticator player_authenticator, ICommandBus command_bus)
        {
            _player_authenticator = player_authenticator;
            _command_bus = command_bus;
        }

        [HttpPost]
        public ActionResult Index()
        {            
            var deal_command = new DealCommand()
            {                
                player_token = _player_authenticator.get_player_token() 
            };

            DomainEvents.register_temp_event_handler<HandResultEvent>(e => this.FlashInfo(e.message));

            _command_bus.send(deal_command);
            
            return RedirectToAction("Display", "BlackJackTableGameView");
        }

    }
}
