using System.Web.Mvc;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;

namespace KojackGames.Blackjack.UI.Web.Controllers.GamePlay
{
    [Authorize]
    public class CreateNewGameController : Controller
    {
        private readonly IPlayerAuthenticator _player_authenticator;                
        private readonly ICommandBus _command_bus;

        public CreateNewGameController(IPlayerAuthenticator player_authenticator, 
                                       IQueryService query_service,
                                       ICommandBus command_bus)
        {
            _player_authenticator = player_authenticator;                                    
            _command_bus = command_bus;
        }

        [HttpPost]
        public ActionResult NewGame()
        {            
            // TODO: Validate that the game has finished

            var clear_finished_game_command =new ClearFinishedGameCommand();
            clear_finished_game_command.player_token = _player_authenticator.get_player_token();
            _command_bus.send(clear_finished_game_command);

            return RedirectToAction("Bet", "Bet");
        }        
    }
}
