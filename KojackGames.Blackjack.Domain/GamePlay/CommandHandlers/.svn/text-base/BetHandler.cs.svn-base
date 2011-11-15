using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.CommandHandlers
{
    public class BetHandler : ICommandHandler<BetCommand>
    {
        private readonly IUnitOfWorkFactory _unit_of_work_factory;
        private IRepository<BlackJackTable> _table_repository;
        private readonly IRepository<Player> _player_repository;
        private IBlackJackTableFactory _blackjack_table_factory;

        public BetHandler(IUnitOfWorkFactory unit_of_work_factory, 
                          IRepository<BlackJackTable> table_repository,
                          IRepository<Player> player_repository,   
                          IBlackJackTableFactory blackjack_table_factory)
        {
            _unit_of_work_factory = unit_of_work_factory;
            _blackjack_table_factory = blackjack_table_factory;
            _table_repository = table_repository;
            _player_repository = player_repository;
        }

        public void handle(BetCommand hand_command)
        {
            using (_unit_of_work_factory.create())
            {
                var player = _player_repository.find_by(hand_command.player_token);

                var table = _table_repository.query_for_single(x => x.player.id == hand_command.player_token);
                
                if (table == null)
                {
                    table = _blackjack_table_factory.create_for(player);                    
                }

                table.place_bet_on_free_position(new Chips(hand_command.wager));

                _table_repository.save(table);
                
            }        
        }
    }
}
