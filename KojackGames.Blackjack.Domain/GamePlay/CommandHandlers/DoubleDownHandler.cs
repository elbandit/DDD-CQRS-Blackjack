using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.CommandHandlers
{
    public class DoubleDownHandler : ICommandHandler<DoubleDownCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private readonly DoubleDown _double_down;
        private readonly IRepository<BlackJackTable> _blackjack_table_repository;


        public DoubleDownHandler(IUnitOfWorkFactory unit_of_work_factory,
                                 IRepository<BlackJackTable> blackjack_table_repository,
                                 DoubleDown double_down)
        {
            _unit_of_work_factory = unit_of_work_factory;            
            _blackjack_table_repository = blackjack_table_repository;
            _double_down = double_down;
        }

        public void handle(DoubleDownCommand hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var game = _blackjack_table_repository.query_for_single(x => x.player.id == hand_command.player_id);
                game.perform_action_with(_double_down);

                _blackjack_table_repository.save(game);
            }
        }
    }
}
