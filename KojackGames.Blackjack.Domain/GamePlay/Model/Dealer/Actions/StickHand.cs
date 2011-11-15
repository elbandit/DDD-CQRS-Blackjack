using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class StickHand : DealerActionOnPlayersHand, IDealerAction
    {
        public StickHand(IHandStatusFactory hand_status_factory, IPlayDealersHand play_dealers_hand, IAnnouceWinnerAction annouce_winner_action)
            : base(hand_status_factory, play_dealers_hand, annouce_winner_action)
        {
        }
       
        public override void action_to_perform(IPlayingPositions playing_positions, ICardShoe card_shoe, IPlayer player)
        {
            raise_illegal_move_if_action_cannot_be_made_on(playing_positions, player);

            playing_positions.players_active_hand.change_state_to(HandStatus.stick);            
        }

        public void raise_illegal_move_if_action_cannot_be_made_on(IPlayingPositions playing_positions, IPlayer player)
        {
            if (playing_positions.players_active_hand.turn_ended())
                throw new IllegalMoveException("Cannot stick hand as your turn has ended.");
        }        
    }
}