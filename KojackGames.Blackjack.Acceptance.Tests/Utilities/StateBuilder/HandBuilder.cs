using System;
using System.Collections.Generic;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder
{
    public class HandBuilder
    {
        private readonly HandTableRow _hand_table_row;
        private readonly GameBuilder _game_builder;

        public HandBuilder(HandTableRow hand_table_row, GameBuilder game_builder)
        {
            _hand_table_row = hand_table_row;
            _game_builder = game_builder;            
        }

        public HandBuilder with_status_of(HandStatus hand_status)
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

        public HandBuilder set_as_active()
        {
            _hand_table_row.is_active = true;

            return this;
        }

        public HandBuilder add_cards(List<CardInHandRow> cards)
        {            
            foreach (var card in cards)
            {
                if (card.suit == (int)Suit.Diamonds && card.card_value == (int)CardValue.Ace)
                    throw new ApplicationException("got here!");

                card.hand_id = _hand_table_row.id;                
                _hand_table_row.card_in_hand_rows.Add(card);
            }            

            return this;
        }
    }
}