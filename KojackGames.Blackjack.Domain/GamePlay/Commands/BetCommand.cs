using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;

namespace KojackGames.Blackjack.Domain.GamePlay.Commands
{
    public class BetCommand : ICommand
    {
        public decimal wager { get; set; }
        public Guid player_token { get; set; }        
    }
}
