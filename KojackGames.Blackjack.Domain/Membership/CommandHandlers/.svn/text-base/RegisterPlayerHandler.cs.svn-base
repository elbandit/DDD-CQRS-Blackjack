using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.Membership.Commands;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.Membership.CommandHandlers
{
    public class RegisterPlayerHandler : ICommandHandler<RegisterPlayer>
    {
        private readonly IRepository<Player> _player_repository;
        private readonly IUnitOfWorkFactory _unit_of_work_factory;

        public RegisterPlayerHandler(IRepository<Player> player_repository, 
                                     IUnitOfWorkFactory unit_of_work_factory)
        {
            _player_repository = player_repository;
            _unit_of_work_factory = unit_of_work_factory;
        }

        public void handle(RegisterPlayer hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var player = new Player(hand_command.player_token, hand_command.name);

                _player_repository.save(player);
            }
        }
    }
}
