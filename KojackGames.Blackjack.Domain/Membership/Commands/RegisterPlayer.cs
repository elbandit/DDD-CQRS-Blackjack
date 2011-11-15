using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;

namespace KojackGames.Blackjack.Domain.Membership.Commands
{
    public class RegisterPlayer : ICommand
    {
        public Guid player_token { get; set; }
        public string name { get; set; }
        public string email { get; set; }        
    }
}
