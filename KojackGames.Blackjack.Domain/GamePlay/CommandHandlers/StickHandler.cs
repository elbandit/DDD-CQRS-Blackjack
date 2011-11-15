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
    public class StickHandler : ICommandHandler<StickHandCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private readonly StickHand _dealer;
        private readonly IRepository<BlackJackTable> _blackjack_table_repository;        

        public StickHandler(IUnitOfWorkFactory unit_of_work_factory,
                           StickHand dealer,
                           IRepository<BlackJackTable> blackjack_table_repository)
        {
            _unit_of_work_factory = unit_of_work_factory;
            _dealer = dealer;
            _blackjack_table_repository = blackjack_table_repository;
        }

        public void handle(StickHandCommand hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var blackJackTable = _blackjack_table_repository.query_for_single(x => x.player.id == hand_command.player_id);

                blackJackTable.perform_action_with(_dealer);

                _blackjack_table_repository.save(blackJackTable);
            }
        }
    }
    
}
