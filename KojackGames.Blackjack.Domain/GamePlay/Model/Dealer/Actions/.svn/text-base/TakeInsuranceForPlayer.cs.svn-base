using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class TakeInsuranceForPlayer : IDealerAction
    {
        public void perform_on(IPlayingPositions playing_positions, ICardShoe card_shoe, IPlayer player)
        {
            raise_illegal_move_if_action_cannot_be_made_on(playing_positions, player);

            player.decrease_pot_by(playing_positions.players_active_hand.wager.halved());

            playing_positions.players_active_hand.mark_as_taken_insurance();

            playing_positions.players_active_hand.remove_offer_to_take_insurance();
        }

        public void raise_illegal_move_if_action_cannot_be_made_on(IPlayingPositions playing_positions, IPlayer player)
        {
            if (!player.can_afford_to_bet(playing_positions.players_active_hand.wager))
                throw new IllegalMoveException(string.Format("Please cash in to take insurance. You need at least {0} dollars.", playing_positions.players_active_hand.wager.ToString()));            
        }   
    }
}