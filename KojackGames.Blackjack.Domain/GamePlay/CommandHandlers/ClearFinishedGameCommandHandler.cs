using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.CommandHandlers
{
    public class ClearFinishedGameCommandHandler: ICommandHandler<ClearFinishedGameCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private IRepository<BlackJackTable> _table_repository;

        public ClearFinishedGameCommandHandler(IUnitOfWorkFactory unit_of_work_factory, IRepository<BlackJackTable> table_repository)
        {
            _unit_of_work_factory = unit_of_work_factory;
            _table_repository = table_repository;
        }

        public void handle(ClearFinishedGameCommand hand_command)
        {
            using(_unit_of_work_factory.create())
            {            
                var blackjack_table =
                    _table_repository.query_for_single(x => x.player.id == hand_command.player_token);

                _table_repository.remove(blackjack_table);
            }
        }
    }
}
