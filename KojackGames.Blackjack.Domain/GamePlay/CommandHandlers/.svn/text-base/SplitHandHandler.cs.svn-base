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
    public class SplitHandHandler : ICommandHandler<SplitHandCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private readonly IRepository<BlackJackTable> _blackjack_table_repository;
        private readonly SplitHand _dealer;

        public SplitHandHandler(IUnitOfWorkFactory unit_of_work_factory,
                                IRepository<BlackJackTable> blackjack_table_repository, 
                                SplitHand dealer)
        {
            _unit_of_work_factory = unit_of_work_factory;
            this._dealer = dealer;
            _blackjack_table_repository = blackjack_table_repository;
        }

        public void handle(SplitHandCommand hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var game = _blackjack_table_repository.query_for_single(x => x.player.id == hand_command.player_id);
                game.perform_action_with(_dealer);

                _blackjack_table_repository.save(game);
            }
        }
    }
}
