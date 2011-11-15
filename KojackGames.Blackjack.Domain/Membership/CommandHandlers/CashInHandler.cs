using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.Membership.Commands;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.Membership.CommandHandlers
{
    public class CashInHandler : ICommandHandler<CashInCommand>
    {
        private readonly IRepository<Player> _player_repository;
        private readonly IUnitOfWorkFactory _unit_of_work_factory;

        public CashInHandler(IRepository<Player> player_repository, 
                             IUnitOfWorkFactory unit_of_work_factory)
        {
            _player_repository = player_repository;
            _unit_of_work_factory = unit_of_work_factory;
        }

        public void handle(CashInCommand hand_command)
        {
            var player = _player_repository.find_by(hand_command.player_token);

            using (_unit_of_work_factory.create())
            {
                player.increase_pot_by(new Chips(hand_command.amount));

                _player_repository.save(player);
            }
        }
    }
}
