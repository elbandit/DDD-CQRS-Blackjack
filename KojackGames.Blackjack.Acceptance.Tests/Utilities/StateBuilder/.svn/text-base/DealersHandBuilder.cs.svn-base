using System.Collections.Generic;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder
{
    public class DealersHandBuilder
    {
        private readonly HandTableRow _hand_table_row;
        private readonly GameBuilder _game_builder;

        public DealersHandBuilder(HandTableRow hand_table_row, GameBuilder game_builder)
        {
            _hand_table_row = hand_table_row;
            _game_builder = game_builder;            
        }

        public DealersHandBuilder with_status_of(HandStatus hand_status)
        {
            _hand_table_row.state_id = hand_status.id;
            _hand_table_row.state_name = hand_status.name;
            _hand_table_row.turn_ended = hand_status.turn_ended;

            return this;
        }

        public GameBuilder build()
        {
            return _game_builder;
        }

        public DealersHandBuilder add_cards(List<CardInHandRow> cards)
        {
            foreach (var card in cards)
            {
                card.hand_id = _hand_table_row.id;                
                _hand_table_row.card_in_hand_rows.Add(card);
            }            

            return this;
        }
    }
}