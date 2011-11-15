using System;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;

namespace KojackGames.Blackjack.Domain.GamePlay.Commands
{
    public class DealCommand : ICommand
    {        
        public decimal wager { get; set; }        
        public Guid player_token { get; set; }        
    }
}