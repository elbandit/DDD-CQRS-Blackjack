using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.Model
{
    public class BlackJackTable : DomainBase<BlackJackTable>, IEntity, IBlackJackTable
    {                        
        private IPlayingPositions _playing_positions;
        private readonly ICardShoe _card_shoe;
       
        private BlackJackTable() 
        {         
        }

        public BlackJackTable(IPlayer player, ICardShoe card_shoe, IPlayingPositions playing_positions, ITableStatus table_status)
        {
            id = Guid.NewGuid();
            this.player = player;                       
            _card_shoe = card_shoe;
            _playing_positions = playing_positions;
            change_status_to(table_status);            
            _playing_positions.create_dealers_hand_for(this);            
        }
        
        public IPlayer player { get; private set; }
                
        public void place_bet_on_free_position(Chips chips_wagered)
        {            
            if (status.can_accept_bet)
            {
                if (_playing_positions.has_free_position_for_bet())
                {
                    if (player.can_afford_to_bet(chips_wagered))
                    {
                        player.decrease_pot_by(chips_wagered);
                        _playing_positions.place_bet_on_free_position(chips_wagered, this);
                    }
                    else
                        throw new NotEnoughFundsException("You will need to cash in to place a bet.");
                }
                else
                    throw new IllegalMoveException("There are no more free positions to place a bet.");

                if (!_playing_positions.has_free_position_for_bet())
                    change_status_to(TableStatus.full_table);
            }                           
        }
        
        public void perform_action_with(IDealerAction dealer_action)
        {            
            dealer_action.perform_on(_playing_positions, _card_shoe, player);
            determine_table_status();            
        }

        private void determine_table_status()
        {
            if (_playing_positions.player_has_finished())
                change_status_to(TableStatus.game_finished);
            else
                change_status_to(TableStatus.in_play);
        }

        private ITableStatus status { get; set; }   
     
        public bool has_finished()
        {
            return status.Equals(status.finished);
        }

        private void change_status_to(ITableStatus status)
        {
            this.status = status;
        }       
    }
}