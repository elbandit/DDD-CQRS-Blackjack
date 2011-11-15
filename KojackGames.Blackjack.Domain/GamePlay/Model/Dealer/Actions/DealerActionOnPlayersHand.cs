using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public abstract class DealerActionOnPlayersHand
    {
        private readonly IHandStatusFactory _hand_status_factory;
        private readonly IPlayDealersHand _play_dealers_hand;
        private readonly IAnnouceWinnerAction _annouce_winner_action;

        public DealerActionOnPlayersHand(IHandStatusFactory hand_status_factory, 
                                         IPlayDealersHand play_dealers_hand,
                                         IAnnouceWinnerAction annouce_winner_action)
        {
            _hand_status_factory = hand_status_factory;
            _play_dealers_hand = play_dealers_hand;
            _annouce_winner_action = annouce_winner_action;
        }

        public void perform_on(IPlayingPositions playing_positions, ICardShoe card_shoe, IPlayer player)
        {
            action_to_perform(playing_positions, card_shoe, player);

            update_hand_status(playing_positions);

            if (should_play_dealers_hand(playing_positions))
                play_dealers_hand(playing_positions, card_shoe, player);

            playing_positions.clear_all_first_hand_decision_offers();

            playing_positions.update_active_hand();
        }
       
        private bool should_play_dealers_hand(IPlayingPositions hands)
        {
            return hands.player_has_finished();
        }

        public abstract void action_to_perform(IPlayingPositions playing_positions, ICardShoe card_shoe, IPlayer player);

        public void play_dealers_hand(IPlayingPositions hands, ICardShoe card_shoe, IPlayer player)
        {            
            _play_dealers_hand.draw_cards_for_dealer_in(hands, card_shoe);
            _annouce_winner_action.determine_winner_from(hands, player);                   
        }

        public void update_hand_status(IPlayingPositions hands)
        {
            var players_active_hand = hands.players_active_hand;
            _hand_status_factory.set_status_for(players_active_hand);
        }
    }
}
