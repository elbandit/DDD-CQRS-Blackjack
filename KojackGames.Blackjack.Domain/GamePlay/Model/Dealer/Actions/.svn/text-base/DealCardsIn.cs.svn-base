using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class DealCardsIn : IDealerAction
    {
        private readonly IHandStatusFactory _hand_status_factory;
        private readonly IAnnouceWinnerAction _annouce_winner_action;
        private readonly ICanDoubleDown _double_down_spec;
        private readonly ICanSplit _split_spec;
        private readonly ICanTakeInsurance _insurance_spec;

        public DealCardsIn(IHandStatusFactory hand_status_factory, IAnnouceWinnerAction annouce_winner_action, 
                           ICanDoubleDown double_down_spec, ICanSplit split_spec, ICanTakeInsurance insurance_spec)
        {
            _hand_status_factory = hand_status_factory;
            _annouce_winner_action = annouce_winner_action;
            _double_down_spec = double_down_spec;
            _split_spec = split_spec;
            _insurance_spec = insurance_spec;
        }

        private void deal_two_cards_to_each_hand_in(IPlayingPositions hands, ICardShoe card_shoe)
        {
            int no_of_cards_to_deal = 2;

            while (no_of_cards_to_deal > 0)
            {                
                hands.players_active_hand.add(card_shoe.take_card());
                hands.dealers_hand.add(card_shoe.take_card());
                
                no_of_cards_to_deal--;
            };            
        }

        public bool can_perform_on(IPlayingPositions playing_positions)
        {
            return playing_positions.have_cards_been_dealt() == false;
        }

        public void perform_on(IPlayingPositions playing_positions, ICardShoe card_shoe, IPlayer player)
        {
            raise_illegal_move_if_action_cannot_be_made_on(playing_positions);

            deal_two_cards_to_each_hand_in(playing_positions, card_shoe);

            update_the_status_of_each_hand_in(playing_positions);

            if (playing_positions.player_has_blackjack())
                _annouce_winner_action.determine_winner_from(playing_positions, player);

            check_if_player_can_double_down(playing_positions);

            check_if_player_can_split(playing_positions);

            check_if_player_can_take_insurance(playing_positions);

            playing_positions.mark_cards_as_dealt();

            playing_positions.update_active_hand();
        }

        private void check_if_player_can_take_insurance(IPlayingPositions playing_positions)
        {
            if (_insurance_spec.is_satisfied_by(playing_positions.dealers_hand))            
                playing_positions.players_active_hand.mark_as_able_to_take_insurance();            
        }

        public void raise_illegal_move_if_action_cannot_be_made_on(IPlayingPositions playing_positions)
        {
            if (playing_positions.have_cards_been_dealt())
                throw new IllegalMoveException("Cannot stick hand as your turn has ended.");
        }

        private void check_if_player_can_split(IPlayingPositions playing_positions)
        {
            if (_split_spec.is_satisfied_by(playing_positions.players_active_hand))
                playing_positions.players_active_hand.mark_as_able_to_split();
        }

        private void check_if_player_can_double_down(IPlayingPositions playing_positions)
        {
            if (_double_down_spec.is_satisfied_by(playing_positions.players_active_hand))
                playing_positions.players_active_hand.mark_as_able_to_double_down();
        }

        protected void update_the_status_of_each_hand_in(IPlayingPositions playing_positions)
        {
            foreach (var hand in playing_positions.all_hands)
                _hand_status_factory.set_status_for(hand);            
        }
    }
}
