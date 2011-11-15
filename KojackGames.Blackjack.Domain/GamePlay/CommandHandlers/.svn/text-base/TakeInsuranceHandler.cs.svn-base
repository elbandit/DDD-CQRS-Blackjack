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
    public class TakeInsuranceHandler : ICommandHandler<TakeInsuranceCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private readonly TakeInsuranceForPlayer _take_insurance_for_player;
        private readonly IRepository<BlackJackTable> _blackjack_table_repository;

        public TakeInsuranceHandler(IRepository<BlackJackTable> blackjack_table_repository, 
                                    IUnitOfWorkFactory unit_of_work_factory,
                                    TakeInsuranceForPlayer take_insurance_for_player)
        {
            _blackjack_table_repository = blackjack_table_repository;
            _unit_of_work_factory = unit_of_work_factory;
            _take_insurance_for_player = take_insurance_for_player;
        }

        public void handle(TakeInsuranceCommand hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var game = _blackjack_table_repository.query_for_single(x => x.player.id == hand_command.player_id);
                game.perform_action_with(_take_insurance_for_player);

                _blackjack_table_repository.save(game);
            }
        }
    }
}
