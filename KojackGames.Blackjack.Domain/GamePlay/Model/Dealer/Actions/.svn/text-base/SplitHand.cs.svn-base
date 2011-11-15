using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class SplitHand : DealerActionOnPlayersHand, IDealerAction
    {
        public SplitHand(IHandStatusFactory hand_status_factory, IPlayDealersHand play_dealers_hand, IAnnouceWinnerAction annouce_winner_action)
            : base(hand_status_factory, play_dealers_hand, annouce_winner_action)
        {            
        }
                
        public override void action_to_perform(IPlayingPositions playing_positions, ICardShoe card_shoe, IPlayer player)
        {
            raise_illegal_move_if_action_cannot_be_made_on(playing_positions, player);

            player.decrease_pot_by(playing_positions.players_active_hand.wager);

            playing_positions.split_players_hand();

            foreach (var hand in playing_positions.players_hands())
            {
                hand.add(card_shoe.take_card());
            }                                        
        }

        public void raise_illegal_move_if_action_cannot_be_made_on(IPlayingPositions playing_positions, IPlayer player)
        {
            if (!player.can_afford_to_bet(playing_positions.players_active_hand.wager))
                throw new IllegalMoveException(string.Format("Please cash in to Split. You need at least {0} dollars.", playing_positions.players_active_hand.wager.ToString()));            
        }
    }
}