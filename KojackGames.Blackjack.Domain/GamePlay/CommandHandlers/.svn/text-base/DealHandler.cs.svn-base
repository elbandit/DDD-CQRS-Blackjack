using System;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.CommandHandlers
{
    public class DealHandler : ICommandHandler<DealCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private readonly DealCardsIn _dealer;
        private readonly IRepository<BlackJackTable> _table_repository;       
        
        public DealHandler(IUnitOfWorkFactory unit_of_work_factory,
                           DealCardsIn dealer,
                           IRepository<BlackJackTable> table_repository)
        {
            _unit_of_work_factory = unit_of_work_factory;
            _dealer = dealer;
            _table_repository = table_repository;        
        }

        public void handle(DealCommand hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var table = _table_repository.query_for_single(x => x.player.id == hand_command.player_token);               

                 if (table != null)
                 {
                    table.perform_action_with(_dealer);                                                                                                                                                                                                                                    
                    _table_repository.save(table);
                 }                                       
            }            
        }        
    }
}
